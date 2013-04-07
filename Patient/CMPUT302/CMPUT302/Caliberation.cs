using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMPUT302
{
    public partial class Caliberation : Form
    {

        private int px = 0;
        private int pz = 0;
        private float mx = 0;
        private float mz = 0;
        private int HalfWidth = Convert.ToInt32(System.Windows.SystemParameters.WorkArea.Width/2);
        private int HalfHeight = Convert.ToInt32(System.Windows.SystemParameters.WorkArea.Height/2);
        

        public Caliberation()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; ;
            
        }
        public float getX()
        {
            return mx;
        }
        public float getZ()
        {
            return mz;
        }
        public void setX(float x )
        {
            this.mx = x;
            
        }
        public void setZ(float z)
        {

            this.mz =z;
        }
        
        public void Counter(float x, float y, float z)
        {
            xCord.Text = Convert.ToString(Math.Round(x, 3));
            yCord.Text = Convert.ToString(Math.Round(y, 3));
            zCord.Text = Convert.ToString(Math.Round(z, 3));
            this.mx = x;
            this.mz = z;
            

        }
      

        public void WinCord(int w, int h)
        {
            wCord.Text = Convert.ToString(w);
            hCord.Text = Convert.ToString(h);
        }

        
        public void RedSignalStatus(int on)
        {
            if (on == 0) 
                RedSignal.BackColor = Color.White;
            else
                RedSignal.BackColor = Color.Red;
        }

        public void YellowSignalStatus(int on)
        {
            if (on == 0)
                YellowSignal.BackColor = Color.White;
            else
                YellowSignal.BackColor = Color.Yellow;
        }

        public void GreenSignalStatus(int on)
        {
            if (on == 0)
                GreenSignal.BackColor = Color.White;
            else
                GreenSignal.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rCord.Text = "Yes";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rCord.Text = "No";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void C1_Click(object sender, EventArgs e)
        {
            rCord.Text = "C1-"+HalfWidth.ToString();
            px = Cursor.Position.X;
            pz = Cursor.Position.Y;
            mx = 1.75F;
            mz = 0.75F;
            xCord.Text = mx.ToString();
            zCord.Text = mz.ToString();
            wCord.Text = px.ToString();
            hCord.Text = pz.ToString();
            XScale.Text = Convert.ToInt16((HalfWidth/(px - HalfWidth)) * mx).ToString();
            YScale.Text = Convert.ToInt16((HalfHeight/pz)*mz).ToString();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            rCord.Text = "C2-"+HalfWidth.ToString();
            px = Cursor.Position.X;
            pz = Cursor.Position.Y;
            mx = getX();
            mz = getZ();
            xCord.Text = mx.ToString();
            zCord.Text = mz.ToString();
            wCord.Text = px.ToString();
            hCord.Text = pz.ToString();
            XScale.Text = Convert.ToInt16((HalfWidth / (px - HalfWidth)) * mx).ToString();
            YScale.Text = Convert.ToInt16((HalfHeight / pz) * mz).ToString();
            Debug.WriteLine("C2 x Scale : " + XScale);
            Debug.WriteLine("C2 yScale : " + YScale);
        }

       

        private void C3_Click(object sender, EventArgs e)
        {
            rCord.Text = "C3-" + HalfWidth.ToString();
            px = Cursor.Position.X;
            pz = Cursor.Position.Y;
            mx = getX();
            mz = getZ();
            xCord.Text = mx.ToString();
            zCord.Text = mz.ToString();
            wCord.Text = px.ToString();
            hCord.Text = pz.ToString();
            XScale.Text = Convert.ToInt16((HalfWidth / (px - HalfWidth)) * mx).ToString();
            YScale.Text = Convert.ToInt16((HalfHeight / pz) * mz).ToString();
            Debug.WriteLine("C3 x Scale : " + XScale);
            Debug.WriteLine("C3 yScale : " + YScale);

        }

        private void C4_Click(object sender, EventArgs e)
        {
            rCord.Text = "C4-" + HalfWidth.ToString();
            px = Cursor.Position.X;
            pz = Cursor.Position.Y;
            mx = -6.75F;
            mz = 0.75F;
            xCord.Text = mx.ToString();
            zCord.Text = mz.ToString();
            wCord.Text = px.ToString();
            hCord.Text = pz.ToString();
            XScale.Text = Convert.ToInt16((HalfWidth / (px - HalfWidth)) * mx).ToString();
            YScale.Text = Convert.ToInt16((HalfHeight / pz) * mz).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void xCord_TextChanged(object sender, EventArgs e)
        {

        }

        public float z { get; set; }
    }
}
