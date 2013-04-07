using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InteractiveFloorGame
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (textBoxPName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a valid name.");
            }
            else
            {
                PatientProfile patient = new PatientProfile();
                patient.name = textBoxPName.Text;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = patient.name + ".txt";
                sfd.DefaultExt = ".txt";
                sfd.AddExtension = true;
                sfd.ShowDialog();
                patient.filePath = sfd.FileName;

                // make new client file
                StreamWriter sw = new StreamWriter(patient.filePath);
                sw.WriteLine(patient.name);

                ControlForm.currentPatient = patient;

                sw.Close();
                Close();
            }
        }

        private void textBoxPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AcceptButton_Click(sender, e);
            }
        }
    }
}
