namespace CMPUT302
{
    partial class Caliberation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xCord = new System.Windows.Forms.TextBox();
            this.yCord = new System.Windows.Forms.TextBox();
            this.zCord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wCord = new System.Windows.Forms.TextBox();
            this.hCord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.GreenSignal = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.YellowSignal = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.RedSignal = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.rCord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C4 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.XScale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.YScale = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xCord
            // 
            this.xCord.Location = new System.Drawing.Point(1057, 26);
            this.xCord.Name = "xCord";
            this.xCord.Size = new System.Drawing.Size(85, 20);
            this.xCord.TabIndex = 0;
            this.xCord.TextChanged += new System.EventHandler(this.xCord_TextChanged);
            // 
            // yCord
            // 
            this.yCord.Location = new System.Drawing.Point(1057, 55);
            this.yCord.Name = "yCord";
            this.yCord.Size = new System.Drawing.Size(85, 20);
            this.yCord.TabIndex = 1;
            // 
            // zCord
            // 
            this.zCord.Location = new System.Drawing.Point(1057, 84);
            this.zCord.Name = "zCord";
            this.zCord.Size = new System.Drawing.Size(85, 20);
            this.zCord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1008, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1008, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1008, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z";
            // 
            // wCord
            // 
            this.wCord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.wCord.Location = new System.Drawing.Point(1057, 113);
            this.wCord.Name = "wCord";
            this.wCord.Size = new System.Drawing.Size(85, 20);
            this.wCord.TabIndex = 6;
            // 
            // hCord
            // 
            this.hCord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hCord.Location = new System.Drawing.Point(1057, 142);
            this.hCord.Name = "hCord";
            this.hCord.Size = new System.Drawing.Size(85, 20);
            this.hCord.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(998, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X Pixel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Z Pixel";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.GreenSignal,
            this.ovalShape6,
            this.YellowSignal,
            this.ovalShape4,
            this.ovalShape3,
            this.RedSignal,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1239, 371);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // GreenSignal
            // 
            this.GreenSignal.FillColor = System.Drawing.Color.Green;
            this.GreenSignal.FillGradientColor = System.Drawing.Color.Red;
            this.GreenSignal.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.GreenSignal.Location = new System.Drawing.Point(1172, 126);
            this.GreenSignal.Name = "GreenSignal";
            this.GreenSignal.Size = new System.Drawing.Size(30, 29);
            // 
            // ovalShape6
            // 
            this.ovalShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape6.Location = new System.Drawing.Point(1166, 119);
            this.ovalShape6.Name = "ovalShape6";
            this.ovalShape6.Size = new System.Drawing.Size(42, 42);
            // 
            // YellowSignal
            // 
            this.YellowSignal.FillColor = System.Drawing.Color.Yellow;
            this.YellowSignal.FillGradientColor = System.Drawing.Color.Yellow;
            this.YellowSignal.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.YellowSignal.Location = new System.Drawing.Point(1172, 77);
            this.YellowSignal.Name = "YellowSignal";
            this.YellowSignal.Size = new System.Drawing.Size(30, 29);
            // 
            // ovalShape4
            // 
            this.ovalShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape4.Location = new System.Drawing.Point(1166, 70);
            this.ovalShape4.Name = "ovalShape4";
            this.ovalShape4.Size = new System.Drawing.Size(42, 42);
            // 
            // ovalShape3
            // 
            this.ovalShape3.FillColor = System.Drawing.Color.Red;
            this.ovalShape3.FillGradientColor = System.Drawing.Color.Red;
            this.ovalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape3.Location = new System.Drawing.Point(1172, 76);
            this.ovalShape3.Name = "ovalShape3";
            this.ovalShape3.Size = new System.Drawing.Size(30, 29);
            // 
            // RedSignal
            // 
            this.RedSignal.FillColor = System.Drawing.Color.Red;
            this.RedSignal.FillGradientColor = System.Drawing.Color.Red;
            this.RedSignal.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.RedSignal.Location = new System.Drawing.Point(1172, 30);
            this.RedSignal.Name = "RedSignal";
            this.RedSignal.Size = new System.Drawing.Size(30, 29);
            // 
            // ovalShape1
            // 
            this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape1.Location = new System.Drawing.Point(1166, 24);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(42, 42);
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(915, 43);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(63, 34);
            this.YesButton.TabIndex = 11;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(915, 88);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(63, 34);
            this.NoButton.TabIndex = 12;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // rCord
            // 
            this.rCord.Location = new System.Drawing.Point(1057, 171);
            this.rCord.Name = "rCord";
            this.rCord.Size = new System.Drawing.Size(85, 20);
            this.rCord.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(997, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Result";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(915, 137);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(63, 34);
            this.ReturnButton.TabIndex = 15;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(825, 38);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(39, 29);
            this.C1.TabIndex = 16;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(825, 310);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(39, 29);
            this.C2.TabIndex = 17;
            this.C2.Text = "C2";
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // C4
            // 
            this.C4.Location = new System.Drawing.Point(32, 45);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(39, 29);
            this.C4.TabIndex = 18;
            this.C4.Text = "C4";
            this.C4.UseVisualStyleBackColor = true;
            this.C4.Click += new System.EventHandler(this.C4_Click);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(715, 310);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(39, 29);
            this.C3.TabIndex = 19;
            this.C3.Text = "C3";
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.C3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(997, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "XScale";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // XScale
            // 
            this.XScale.Location = new System.Drawing.Point(1057, 200);
            this.XScale.Name = "XScale";
            this.XScale.Size = new System.Drawing.Size(85, 20);
            this.XScale.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(997, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "YScale";
            // 
            // YScale
            // 
            this.YScale.Location = new System.Drawing.Point(1057, 229);
            this.YScale.Name = "YScale";
            this.YScale.Size = new System.Drawing.Size(85, 20);
            this.YScale.TabIndex = 22;
            // 
            // Caliberation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 371);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YScale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.XScale);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rCord);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hCord);
            this.Controls.Add(this.wCord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zCord);
            this.Controls.Add(this.yCord);
            this.Controls.Add(this.xCord);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Caliberation";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xCord;
        private System.Windows.Forms.TextBox yCord;
        private System.Windows.Forms.TextBox zCord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wCord;
        private System.Windows.Forms.TextBox hCord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape RedSignal;
        private Microsoft.VisualBasic.PowerPacks.OvalShape GreenSignal;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape6;
        private Microsoft.VisualBasic.PowerPacks.OvalShape YellowSignal;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape3;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.TextBox rCord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C4;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox XScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox YScale;
    }
}