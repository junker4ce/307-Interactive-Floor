namespace InteractiveFloorGame
{
    partial class ControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.game_panel = new System.Windows.Forms.Panel();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.timeChoice = new System.Windows.Forms.NumericUpDown();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.square1 = new System.Windows.Forms.Button();
            this.footButton = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.controls_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label_position = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.positionBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colGameNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientTab = new System.Windows.Forms.TabPage();
            this.S = new System.Windows.Forms.TabPage();
            this.removeLevelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeDigits = new System.Windows.Forms.TextBox();
            this.positionDigits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveLevelBtn = new System.Windows.Forms.Button();
            this.presetLevelsComboBox = new System.Windows.Forms.ComboBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.continuousList = new System.Windows.Forms.ListBox();
            this.continuousChBx = new System.Windows.Forms.CheckBox();
            this.game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChoice)).BeginInit();
            this.controls_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.patientTab.SuspendLayout();
            this.S.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.Color.Tan;
            this.game_panel.Controls.Add(this.labelSeconds);
            this.game_panel.Controls.Add(this.timeChoice);
            this.game_panel.Controls.Add(this.button8);
            this.game_panel.Controls.Add(this.button7);
            this.game_panel.Controls.Add(this.button6);
            this.game_panel.Controls.Add(this.button5);
            this.game_panel.Controls.Add(this.button4);
            this.game_panel.Controls.Add(this.button3);
            this.game_panel.Controls.Add(this.button2);
            this.game_panel.Controls.Add(this.square1);
            this.game_panel.Controls.Add(this.footButton);
            this.game_panel.Location = new System.Drawing.Point(406, 27);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(278, 255);
            this.game_panel.TabIndex = 0;
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(0, 5);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(57, 13);
            this.labelSeconds.TabIndex = 11;
            this.labelSeconds.Text = "Time Limit:";
            // 
            // timeChoice
            // 
            this.timeChoice.Location = new System.Drawing.Point(58, 3);
            this.timeChoice.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.timeChoice.Name = "timeChoice";
            this.timeChoice.Size = new System.Drawing.Size(52, 20);
            this.timeChoice.TabIndex = 10;
            this.timeChoice.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkCyan;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.SpringGreen;
            this.button8.Location = new System.Drawing.Point(115, 29);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.Resize += new System.EventHandler(this.button8_Resize);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkCyan;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.SpringGreen;
            this.button7.Location = new System.Drawing.Point(62, 52);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.Resize += new System.EventHandler(this.button7_Resize);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkCyan;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.SpringGreen;
            this.button6.Location = new System.Drawing.Point(46, 103);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.Resize += new System.EventHandler(this.button6_Resize);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.SpringGreen;
            this.button5.Location = new System.Drawing.Point(62, 153);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.Resize += new System.EventHandler(this.button5_Resize);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.SpringGreen;
            this.button4.Location = new System.Drawing.Point(115, 169);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Resize += new System.EventHandler(this.button4_Resize);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.SpringGreen;
            this.button3.Location = new System.Drawing.Point(170, 153);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Resize += new System.EventHandler(this.button3_Resize);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(188, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Resize += new System.EventHandler(this.button2_Resize);
            // 
            // square1
            // 
            this.square1.BackColor = System.Drawing.Color.DarkCyan;
            this.square1.FlatAppearance.BorderSize = 0;
            this.square1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square1.ForeColor = System.Drawing.Color.SpringGreen;
            this.square1.Location = new System.Drawing.Point(170, 52);
            this.square1.Margin = new System.Windows.Forms.Padding(0);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(40, 40);
            this.square1.TabIndex = 0;
            this.square1.Text = "1";
            this.square1.UseVisualStyleBackColor = false;
            this.square1.Click += new System.EventHandler(this.square1_Click);
            this.square1.Resize += new System.EventHandler(this.square1_Resize);
            // 
            // footButton
            // 
            this.footButton.FlatAppearance.BorderSize = 0;
            this.footButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.footButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.footButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footButton.Image = ((System.Drawing.Image)(resources.GetObject("footButton.Image")));
            this.footButton.Location = new System.Drawing.Point(116, 102);
            this.footButton.Margin = new System.Windows.Forms.Padding(0);
            this.footButton.Name = "footButton";
            this.footButton.Size = new System.Drawing.Size(39, 39);
            this.footButton.TabIndex = 9;
            this.footButton.UseVisualStyleBackColor = true;
            this.footButton.Click += new System.EventHandler(this.footButton_Click);
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(97, 44);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(75, 34);
            this.play_button.TabIndex = 8;
            this.play_button.Text = "Play!";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(3, 44);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(77, 34);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset Board";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // controls_panel
            // 
            this.controls_panel.Controls.Add(this.button1);
            this.controls_panel.Controls.Add(this.play_button);
            this.controls_panel.Controls.Add(this.resetButton);
            this.controls_panel.Location = new System.Drawing.Point(406, 296);
            this.controls_panel.Name = "controls_panel";
            this.controls_panel.Size = new System.Drawing.Size(278, 86);
            this.controls_panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(7, 141);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(44, 13);
            this.label_position.TabIndex = 12;
            this.label_position.Text = "Position";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(7, 196);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(27, 13);
            this.label_size.TabIndex = 10;
            this.label_size.Text = "Size";
            // 
            // sizeBar
            // 
            this.sizeBar.Location = new System.Drawing.Point(56, 193);
            this.sizeBar.Maximum = 100;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(137, 45);
            this.sizeBar.SmallChange = 0;
            this.sizeBar.TabIndex = 0;
            this.sizeBar.TabStop = false;
            this.sizeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sizeBar.Scroll += new System.EventHandler(this.sizeBar_Scroll);
            // 
            // positionBar
            // 
            this.positionBar.Location = new System.Drawing.Point(57, 138);
            this.positionBar.Maximum = 100;
            this.positionBar.Name = "positionBar";
            this.positionBar.Size = new System.Drawing.Size(137, 45);
            this.positionBar.SmallChange = 0;
            this.positionBar.TabIndex = 11;
            this.positionBar.TabStop = false;
            this.positionBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.positionBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muneToolStripMenuItem
            // 
            this.muneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadPatientToolStripMenuItem,
            this.savePatientToolStripMenuItem,
            this.toolStripSeparator2});
            this.muneToolStripMenuItem.Name = "muneToolStripMenuItem";
            this.muneToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.muneToolStripMenuItem.Text = "Patient";
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newPatientToolStripMenuItem.Text = "New Patient";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // loadPatientToolStripMenuItem
            // 
            this.loadPatientToolStripMenuItem.Name = "loadPatientToolStripMenuItem";
            this.loadPatientToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadPatientToolStripMenuItem.Text = "Load Patient";
            this.loadPatientToolStripMenuItem.Click += new System.EventHandler(this.loadPatientToolStripMenuItem_Click);
            // 
            // savePatientToolStripMenuItem
            // 
            this.savePatientToolStripMenuItem.Name = "savePatientToolStripMenuItem";
            this.savePatientToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.savePatientToolStripMenuItem.Text = "Save Patient";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGameNumber,
            this.colScore,
            this.outOf,
            this.time,
            this.foot});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(383, 329);
            this.dataGridView1.TabIndex = 3;
            // 
            // colGameNumber
            // 
            this.colGameNumber.HeaderText = "Game Number";
            this.colGameNumber.Name = "colGameNumber";
            this.colGameNumber.ReadOnly = true;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "Score";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Width = 60;
            // 
            // outOf
            // 
            this.outOf.HeaderText = "Out of:";
            this.outOf.Name = "outOf";
            this.outOf.ReadOnly = true;
            this.outOf.Width = 64;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 55;
            // 
            // foot
            // 
            this.foot.HeaderText = "Foot";
            this.foot.Name = "foot";
            this.foot.ReadOnly = true;
            this.foot.Width = 53;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(84, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(180, 20);
            this.nameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientTab);
            this.tabControl1.Controls.Add(this.S);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 355);
            this.tabControl1.TabIndex = 6;
            // 
            // patientTab
            // 
            this.patientTab.Controls.Add(this.dataGridView1);
            this.patientTab.Location = new System.Drawing.Point(4, 22);
            this.patientTab.Name = "patientTab";
            this.patientTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientTab.Size = new System.Drawing.Size(383, 329);
            this.patientTab.TabIndex = 0;
            this.patientTab.Text = "Patient Info.";
            this.patientTab.UseVisualStyleBackColor = true;
            // 
            // S
            // 
            this.S.Controls.Add(this.removeLevelBtn);
            this.S.Controls.Add(this.label3);
            this.S.Controls.Add(this.sizeDigits);
            this.S.Controls.Add(this.positionDigits);
            this.S.Controls.Add(this.label_position);
            this.S.Controls.Add(this.label_size);
            this.S.Controls.Add(this.label2);
            this.S.Controls.Add(this.sizeBar);
            this.S.Controls.Add(this.saveLevelBtn);
            this.S.Controls.Add(this.positionBar);
            this.S.Controls.Add(this.presetLevelsComboBox);
            this.S.Controls.Add(this.removeBtn);
            this.S.Controls.Add(this.moveDownBtn);
            this.S.Controls.Add(this.moveUpBtn);
            this.S.Controls.Add(this.continuousList);
            this.S.Controls.Add(this.continuousChBx);
            this.S.Location = new System.Drawing.Point(4, 22);
            this.S.Name = "S";
            this.S.Padding = new System.Windows.Forms.Padding(3);
            this.S.Size = new System.Drawing.Size(383, 329);
            this.S.TabIndex = 1;
            this.S.Text = "Level Style";
            this.S.UseVisualStyleBackColor = true;
            // 
            // removeLevelBtn
            // 
            this.removeLevelBtn.Location = new System.Drawing.Point(257, 28);
            this.removeLevelBtn.Name = "removeLevelBtn";
            this.removeLevelBtn.Size = new System.Drawing.Size(83, 23);
            this.removeLevelBtn.TabIndex = 16;
            this.removeLevelBtn.Text = "Delete level";
            this.removeLevelBtn.UseVisualStyleBackColor = true;
            this.removeLevelBtn.Visible = false;
            this.removeLevelBtn.Click += new System.EventHandler(this.removeLevelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preset Levels";
            // 
            // sizeDigits
            // 
            this.sizeDigits.Location = new System.Drawing.Point(199, 193);
            this.sizeDigits.Name = "sizeDigits";
            this.sizeDigits.Size = new System.Drawing.Size(52, 20);
            this.sizeDigits.TabIndex = 14;
            this.sizeDigits.TextChanged += new System.EventHandler(this.sizeDigits_TextChanged);
            // 
            // positionDigits
            // 
            this.positionDigits.Location = new System.Drawing.Point(198, 138);
            this.positionDigits.Name = "positionDigits";
            this.positionDigits.Size = new System.Drawing.Size(53, 20);
            this.positionDigits.TabIndex = 13;
            this.positionDigits.TextChanged += new System.EventHandler(this.positionDigits_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose a pre-set level from the list or create your own:";
            // 
            // saveLevelBtn
            // 
            this.saveLevelBtn.Location = new System.Drawing.Point(257, 29);
            this.saveLevelBtn.Name = "saveLevelBtn";
            this.saveLevelBtn.Size = new System.Drawing.Size(83, 23);
            this.saveLevelBtn.TabIndex = 7;
            this.saveLevelBtn.Text = "Save Level Settings";
            this.saveLevelBtn.UseVisualStyleBackColor = true;
            this.saveLevelBtn.Click += new System.EventHandler(this.saveLevelBtn_Click);
            // 
            // presetLevelsComboBox
            // 
            this.presetLevelsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetLevelsComboBox.FormattingEnabled = true;
            this.presetLevelsComboBox.Location = new System.Drawing.Point(86, 30);
            this.presetLevelsComboBox.Name = "presetLevelsComboBox";
            this.presetLevelsComboBox.Size = new System.Drawing.Size(165, 21);
            this.presetLevelsComboBox.TabIndex = 5;
            this.presetLevelsComboBox.SelectedValueChanged += new System.EventHandler(this.levelNamesComboBox_SelectedValueChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(317, 295);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(55, 23);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.Enabled = false;
            this.moveDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDownBtn.Location = new System.Drawing.Point(287, 295);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(24, 23);
            this.moveDownBtn.TabIndex = 3;
            this.moveDownBtn.Text = "ˇ";
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.Click += new System.EventHandler(this.moveDownBtn_Click);
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.Enabled = false;
            this.moveUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUpBtn.Location = new System.Drawing.Point(257, 295);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(24, 23);
            this.moveUpBtn.TabIndex = 2;
            this.moveUpBtn.Text = "ˆ";
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.Click += new System.EventHandler(this.moveUpBtn_Click);
            // 
            // continuousList
            // 
            this.continuousList.Enabled = false;
            this.continuousList.FormattingEnabled = true;
            this.continuousList.Items.AddRange(new object[] {
            "upper-right",
            "lower-left",
            "bottom",
            "top",
            "left",
            "right"});
            this.continuousList.Location = new System.Drawing.Point(257, 129);
            this.continuousList.Name = "continuousList";
            this.continuousList.Size = new System.Drawing.Size(115, 160);
            this.continuousList.TabIndex = 1;
            // 
            // continuousChBx
            // 
            this.continuousChBx.AutoSize = true;
            this.continuousChBx.Location = new System.Drawing.Point(257, 106);
            this.continuousChBx.Name = "continuousChBx";
            this.continuousChBx.Size = new System.Drawing.Size(108, 17);
            this.continuousChBx.TabIndex = 0;
            this.continuousChBx.Text = "Continuous Level";
            this.continuousChBx.UseVisualStyleBackColor = true;
            this.continuousChBx.CheckedChanged += new System.EventHandler(this.continuousChBx_CheckedChanged);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 392);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.controls_panel);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlForm";
            this.Text = "Control";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChoice)).EndInit();
            this.controls_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.patientTab.ResumeLayout(false);
            this.S.ResumeLayout(false);
            this.S.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.Button square1;
        private System.Windows.Forms.Panel controls_panel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar sizeBar;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.TrackBar positionBar;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePatientToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button footButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn outOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn foot;
        private System.Windows.Forms.NumericUpDown timeChoice;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage patientTab;
        private System.Windows.Forms.TabPage S;
        private System.Windows.Forms.ListBox continuousList;
        private System.Windows.Forms.CheckBox continuousChBx;
        private System.Windows.Forms.TextBox sizeDigits;
        private System.Windows.Forms.TextBox positionDigits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveLevelBtn;
        private System.Windows.Forms.ComboBox presetLevelsComboBox;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.Button moveUpBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeLevelBtn;
        private System.Windows.Forms.Button button1;
    }
}

