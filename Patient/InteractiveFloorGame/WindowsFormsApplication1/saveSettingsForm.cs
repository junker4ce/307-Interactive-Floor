using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InteractiveFloorGame
{
    public partial class saveSettingsForm : Form
    {
        public saveSettingsForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ControlForm.uniqueName(nameTxtBox.Text))
            {
                MessageBox.Show("Please choose a unique level name.");
            }
            else
            {
                ControlForm.saveFormName = nameTxtBox.Text;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                saveBtn_Click(sender, e);
            }
        }
    }
}
