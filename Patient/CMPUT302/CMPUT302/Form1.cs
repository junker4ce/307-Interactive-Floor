using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPUT302
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            button1.Left = 200+Convert.ToInt16(System.Windows.SystemParameters.VirtualScreenWidth / 2 - button1.Width / 2);
            button2.Left = 200+Convert.ToInt16(System.Windows.SystemParameters.VirtualScreenWidth / 2 - button1.Width / 2);
            button3.Left = 200+Convert.ToInt16(System.Windows.SystemParameters.VirtualScreenWidth / 2 - button1.Width / 2);
            label1.Left = Convert.ToInt16(System.Windows.SystemParameters.VirtualScreenWidth / 2 - label1.Width / 2);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Coordinate1 calibration = new Coordinate1();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //this.WindowState =  FormWindowState.Minimized; 
            Caliberation f1 = new Caliberation();
            f1.Show();
            InteractiveFloorGame.ControlForm f2 = new InteractiveFloorGame.ControlForm();
            f2.Show();
            f2.Left = 20;
            f2.Top = 20;
            f1.Left = 850;
            f1.Top = 20;
           // f1.WindowState = FormWindowState.Maximized;
           // f2.WindowState = FormWindowState.Maximized;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
            Application.Exit();
        }

       
    }
}
