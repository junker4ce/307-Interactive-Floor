using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using InteractiveFloorGame.Properties;
using System.Collections.ObjectModel;
using InteractiveFloorGame;



namespace InteractiveFloorGame
{
    public partial class ControlForm : Form
    {
        private bool levelLoaded = true;

        public static Color buttonColour = Color.DarkCyan;
        public static Color pressedColour = Color.Coral;//.Fuchsia;
       
        public Point centre = new Point(0,0);

        public static string saveFormName = "Blank";
        public string currentLvlName = "Blank";
        public string currentLvlData = "Blank";
        public string currentLvlQueue = "Blank";
        public static string userLevelsPath = Application.UserAppDataPath + "\\Interactive_floor_userLevels.txt";
        public static string presetLevelsLocation = "InteractiveFloorGame.Resources.PresetGameSettings.txt";

        public static int distancePercent =55;
        public static int sizePercent = 30;

        public static Assembly _assembly = Assembly.GetExecutingAssembly();

        public static TileInfo[] tiles = new TileInfo[8];

        public Button[] buttons = new Button[8];

        public static PatientProfile currentPatient = null;

        public enum feet { FootRight, FootLeft, FootBoth }
        public static feet currentFoot = feet.FootRight;
        

        Dictionary<string, string> directions = new Dictionary<string, string>
        {
            {"0","Upper right(1)"},
            {"1","Right(2)"},
            {"2","Lower right(3)"},
            {"3","Bottom(4)"},
            {"4","Lower left(5)"},
            {"5","left(6)"},
            {"6","Upper left(7)"},
            {"7","Top(8)"},
        };
        Dictionary<string, string> directionsRevDict = new Dictionary<string, string>
        {
            {"Upper right(1)","0"},
            {"Right(2)","1"},
            {"Lower right(3)","2"},
            {"Bottom(4)","3"},
            {"Lower left(5)","4"},
            {"left(6)","5"},
            {"Upper left(7)","6"},
            {"Top(8)","7"},
        };


        public ControlForm()
        {
            InitializeComponent();

            //for (int i = 0; i < 8; i++)
            //{
            //    directionsRevDict.Add(directions[i]);
            //}

            buttons = new Button[8] { square1, button2, button3, button4, button5, button6, button7, button8 };
            for (int i = 0; i < 8; i++)
            {
                tiles[i] = new TileInfo();
            }

            sizeBar.Value = sizePercent;
            sizeDigits.Text = sizePercent.ToString();
            positionBar.Value = distancePercent;
            positionDigits.Text = distancePercent.ToString();

            this.centre.X = game_panel.Width/2;
            this.centre.Y = game_panel.Height/2;

            update_control_tiles();
            footButton.Location = new Point(centre.X - footButton.Size.Width / 2, centre.Y - footButton.Size.Height / 2);
            footButton.Image = image_resized(Resources.img_rightFoot,footButton.Size);

            continuousList.Items.Clear();

            populatePresetLevelsBox();

            // level settings start at default
        }

        public  string get_foot()
        {
            return currentFoot.ToString();
        }

        private void populatePresetLevelsBox()
        {
            presetLevelsComboBox.Items.Clear();

            // get the built-in presets first
            StreamReader sr = new StreamReader(_assembly.GetManifestResourceStream(presetLevelsLocation));
            List<string> builtinLlevelNames = getLevelNames(sr);
            foreach (string s in builtinLlevelNames)
            {
                presetLevelsComboBox.Items.Add(s);
            }
            sr.Close();

            // get the user-defined presets second
            if (File.Exists(userLevelsPath))
            {
                StreamReader user = new StreamReader(userLevelsPath);
                List<string> userLevelNames = getLevelNames(user);
                foreach (string s in userLevelNames)
                {
                    presetLevelsComboBox.Items.Add(s);
                }
                user.Close();
            }
        }

        public static List<string> getLevelNames(StreamReader strm)
        {
            //string[] names = { };
            List<string> names = new List<string>();
            string name, temp;
            while ((name = strm.ReadLine()) != null)
            {
                if (name[0] == '/')
                {
                    // skip oppening comment line
                }
                else if ((temp = strm.ReadLine()) != null && (temp = strm.ReadLine()) != null)
                {
                    names.Add(name);
                }
            }
            return names;
        }

        public static Bitmap image_resized(Image img, Size size)
        {
            if (size.Height < 1)
            {
                size.Height = 1;
            }
            if (size.Width < 1)
            {
                size.Width = 1;
            }
            return new Bitmap(img, size);
        }

        public void update_control_tiles()
        {
            double s = sizePercent; // as double type
            for (int i = 0; i < 8; i++)
            {
                buttons[i].Height = Convert.ToInt32((s / 100) * (game_panel.Height / 2));
                buttons[i].Width = Convert.ToInt32((s / 100) * (game_panel.Height / 2));
                buttons[i].Location = calc_position(i+1, buttons[i].Size, positionBar.Value, game_panel.Height, centre);
            }
        }

        public static Point calc_position(int branch, Size tileSize, int distancePercent, int height, Point centre)
        {
            Point pos = new Point();
            
            double dist = distancePercent;
            double unit_vector = 0.707106781; // =1/sqrt(1*1+1*1)

            switch (branch)
            {
                case 1: // upper right
                    pos.X = Convert.ToInt32(centre.X + unit_vector * (dist / 100 * (height / 2)));
                    pos.Y = Convert.ToInt32(centre.Y + -unit_vector * (dist / 100 * (height / 2)));
                    break;
                case 2: // right
                    pos.X = Convert.ToInt32(centre.X + (dist / 100 * (height / 2)));
                    pos.Y = centre.Y;
                    break;
                case 3: // lower right
                    pos.X = Convert.ToInt32(centre.X + unit_vector * (dist / 100 * (height / 2)));
                    pos.Y = Convert.ToInt32(centre.Y + unit_vector * (dist / 100 * (height / 2)));
                    break;
                case 4: // bottom
                    pos.X = centre.X;
                    pos.Y = Convert.ToInt32(centre.Y + (dist / 100 * (height / 2)));
                    break;
                case 5: // lower left
                    pos.X = Convert.ToInt32(centre.X + -unit_vector * (dist / 100 * (height / 2)));
                    pos.Y = Convert.ToInt32(centre.Y + unit_vector * (dist / 100 * (height / 2)));
                    break;
                case 6: // left
                    pos.X = Convert.ToInt32(centre.X - (dist / 100 * (height / 2)));
                    pos.Y = centre.Y;
                    break;
                case 7: // upper left
                    pos.X = Convert.ToInt32(centre.X + -unit_vector * (dist / 100 * (height / 2)));
                    pos.Y = Convert.ToInt32(centre.Y + -unit_vector * (dist / 100 * (height / 2)));
                    break;
                case 8: // top
                    pos.X = centre.X;
                    pos.Y = Convert.ToInt32(centre.Y - (dist / 100 * (height / 2)));//((dist + tileSize.Height / 2) / (100 - tileSize.Height / 2) * ((height / 2) - tileSize.Height)));
                    break;
                default:
                    break;
            }
            pos.X = pos.X - tileSize.Width / 2;
            pos.Y = pos.Y - tileSize.Height / 2;
            return pos;
        }

        public void click_tile(int index)
        {
            levelSettingsChangeAction();
            if (continuousChBx.Checked)
            {
                if (tiles[index].on)
                {
                    continuousList.Items.Add(directions[index.ToString()]);
                }
            }
            else
            {
                if (tiles[index].on)
                {
                    setTileActivation(index, false);
                }
                else
                {
                    setTileActivation(index, true);
                }
            }
        }

        private void setTileActivation(int tileIndex, bool setActive)
        {
            if (setActive)
            {
                tiles[tileIndex].on = true;
                buttons[tileIndex].Image = null;
                buttons[tileIndex].BackColor = buttonColour;
            }
            else
            {
                tiles[tileIndex].on = false;
                buttons[tileIndex].Image = image_resized(Resources.img_x, buttons[tileIndex].Size);
                buttons[tileIndex].BackColor = pressedColour;
            }
        }

        public void resize_tile(int index)
        {
            //buttons[index].Image = tiles[index].get_image(buttons[index].Size);
        }



        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                tiles[i].on = true;
                tiles[i].image = null;
                buttons[i].Image = null;
                buttons[i].BackColor = buttonColour;
            }
        }

        private void square1_Click(object sender, EventArgs e)
        {
            click_tile(0);
        }  

        private void button2_Click(object sender, EventArgs e)
        {
            click_tile(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            click_tile(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            click_tile(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            click_tile(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            click_tile(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            click_tile(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            click_tile(7);
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            levelSettingsChangeAction();
            distancePercent = positionBar.Value;
            update_position_guages(distancePercent);
            update_control_tiles();
        }

        private void sizeBar_Scroll(object sender, EventArgs e)
        {
            levelSettingsChangeAction();
            sizePercent = sizeBar.Value;
            update_size_guages(sizePercent);
            update_control_tiles();
        }

        private void update_position_guages(int dist)
        {
            positionBar.Value = dist;
            positionDigits.Text = dist.ToString();
        }

        private void update_size_guages(int size)
        {
            sizeBar.Value = size;
            sizeDigits.Text = size.ToString();
        }

        private void Tracking()
        {
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            
            string[] queue = generate_queue_string().Split(' ');
            // set up tiles for gameplay
            for (int i = 0; i < 8; i++)
            {
                if (tiles[i].on)
                {
                    tiles[i].size = buttons[i].Size;
                    tiles[i].location = buttons[i].Location;

                    // set the initial balloon images
                    // no need to resize image here. image will be resized by gameboard.
                    if (queue[0] == "yes" && queue.Count() > 1 && i == Convert.ToInt32(queue[1]))
                    {
                        tiles[i].image = Resources.img_yellowBalloon;
                    }
                    else
                    {
                        tiles[i].image = Resources.img_blueBalloon;
                    }
                    
                    tiles[i].stepped = false;
                }
            }
            GameForm gameboard = new GameForm(Convert.ToInt32(timeChoice.Value), generate_queue_string().Split(' '));
            gameboard.MaximizeBox = false;
            gameboard.MinimizeBox = false;
            gameboard.Show();
        }

        private void square1_Resize(object sender, EventArgs e)
        {
            resize_tile(0);
        }

        private void button2_Resize(object sender, EventArgs e)
        {
            resize_tile(1);
        }

        private void button3_Resize(object sender, EventArgs e)
        {
            resize_tile(2);
        }

        private void button4_Resize(object sender, EventArgs e)
        {
            resize_tile(3);
        }

        private void button5_Resize(object sender, EventArgs e)
        {
            resize_tile(4);
        }

        private void button6_Resize(object sender, EventArgs e)
        {
            resize_tile(5);
        }

        private void button7_Resize(object sender, EventArgs e)
        {
            resize_tile(6);
        }

        private void button8_Resize(object sender, EventArgs e)
        {
            resize_tile(7);
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient();
            np.Show();
        }

        public static void saveInfo()
        {
            StreamWriter sw = new StreamWriter(currentPatient.filePath);
            sw.WriteLine(currentPatient.name);

            sw.Close();
        }


        public void getPatientInfo()
        {
            // clear grid
            dataGridView1.SelectAll();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }

            if (currentPatient != null)
            {
                nameBox.Text = currentPatient.name;

                StreamReader sr = new StreamReader(currentPatient.filePath);
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split('|');
                    dataGridView1.Rows.Add(columns);
                }

                sr.Close();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            getPatientInfo();
        }

        private void loadPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentPatient = new PatientProfile(ofd.FileName);
                getPatientInfo();
            }
        }

        private void footButton_Click(object sender, EventArgs e)
        {
            if (currentFoot == feet.FootRight)
            {
                currentFoot = feet.FootLeft;
                footButton.Image = new Bitmap(Resources.img_leftFoot, footButton.Size);
            }
            else
            {
                currentFoot = feet.FootRight;
                footButton.Image = new Bitmap(Resources.img_rightFoot, footButton.Size);
            }
            get_foot();
        }

        private void positionDigits_TextChanged(object sender, EventArgs e)
        {
            levelSettingsChangeAction();
            try
            {
                distancePercent = confirmPercent(Convert.ToInt32(positionDigits.Text));
                update_position_guages(distancePercent);
                update_control_tiles();
            }
            catch(Exception)
            {
            }
        }

        private void sizeDigits_TextChanged(object sender, EventArgs e)
        {
            levelSettingsChangeAction();
            try
            {
                sizePercent = confirmPercent(Convert.ToInt32(sizeDigits.Text));
                update_size_guages(sizePercent);
                update_control_tiles();
            }
            catch (Exception)
            {
            }
        }

        private int confirmPercent(int value)
        {
            // makes sure the value is between 0 and 100.
            if      (value < 0)     { value = 0; }
            else if (value > 100)   { value = 100; }
            return value;
        }

        private void continuousChBx_CheckedChanged(object sender, EventArgs e)
        {
            levelSettingsChangeAction();
            if (continuousChBx.Checked)
            {
                // activate buttons and DDR queue
                continuousList.Enabled = true;
                moveUpBtn.Enabled = true;
                moveDownBtn.Enabled = true;
                removeBtn.Enabled = true;
            }
            else
            {
                // deactivate buttons and DDR queue
                continuousList.Items.Clear();
                continuousList.Enabled = false;
                moveUpBtn.Enabled = false;
                moveDownBtn.Enabled = false;
                removeBtn.Enabled = false;
            }
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {
            levelSettingsChangeAction();
            if (continuousList.SelectedIndex > -1)
            {
                object tempItem = continuousList.SelectedItem;
                int currentIndex = continuousList.SelectedIndex;
                if (currentIndex > 0)
                {
                    continuousList.Items.RemoveAt(currentIndex);
                    continuousList.Items.Insert(currentIndex - 1, tempItem);
                    continuousList.SelectedIndex = currentIndex - 1;
                }
            }
        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {
            levelSettingsChangeAction();
            if (continuousList.SelectedIndex > -1)
            {
                object tempItem = continuousList.SelectedItem;
                int currentIndex = continuousList.SelectedIndex;
                if (currentIndex < continuousList.Items.Count - 1)
                {
                    continuousList.Items.RemoveAt(currentIndex);
                    continuousList.Items.Insert(currentIndex + 1, tempItem);
                    continuousList.SelectedIndex = currentIndex + 1;
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            levelSettingsChangeAction();
            if (continuousList.SelectedIndex > -1)
            {
                int tempIndex = continuousList.SelectedIndex;
                continuousList.Items.RemoveAt(tempIndex);
                continuousList.SelectedIndex = tempIndex;
            }
        }

        private void levelNamesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            levelLoaded = false;
            bool foundPreset = false;
            bool foundUsrLvl = false;
            try
            {
                // look in the preset levels first
                StreamReader sr = new StreamReader(_assembly.GetManifestResourceStream(presetLevelsLocation));
                string levelName, levelData, levelQueue;
                while ((levelName = sr.ReadLine()) != null)
                {
                    if (levelName[0] == '/')
                    {
                        // skip comment line
                    }
                    else if ((levelData = sr.ReadLine()) != null && (levelQueue = sr.ReadLine()) != null)
                    {
                        if (String.Compare(levelName, presetLevelsComboBox.Text) == 0)
                        {
                            foundPreset = true;
                            currentLvlName = levelName;
                            currentLvlData = levelData;
                            currentLvlQueue = levelQueue;
                            break;
                        }
                    }
                }
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot read Level File.");
            }

            if (foundPreset)
            {
                saveLevelBtn.Visible = false;
                removeLevelBtn.Visible = false;
                apply_level_settings(currentLvlName, currentLvlData.Split(' '), currentLvlQueue.Split(' '));
            }
            else
            {
                try
                {
                    // look in the user defined levels second
                    StreamReader sr = new StreamReader(userLevelsPath);
                    string levelName, levelData, levelQueue;
                    while ((levelName = sr.ReadLine()) != null)
                    {
                        if (levelName[0] == '/')
                        {
                            // skip comment line
                        }
                        else if ((levelData = sr.ReadLine()) != null && (levelQueue = sr.ReadLine()) != null)
                        {
                            if (String.Compare(levelName, presetLevelsComboBox.Text) == 0)
                            {
                                foundUsrLvl = true;
                                currentLvlName = levelName;
                                currentLvlData = levelData;
                                currentLvlQueue = levelQueue;
                                break;
                            }
                        }
                    }
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot read user defined level file.");
                }
            }

            if (foundUsrLvl)
            {
                saveLevelBtn.Visible = false;
                removeLevelBtn.Visible = true;
                apply_level_settings(currentLvlName, currentLvlData.Split(' '), currentLvlQueue.Split(' '));
            }
            levelLoaded = true;
        }

        private void apply_level_settings(string name, string[] data, string[] queue)
        {
            //levelNameTxtBox.Text = name;
            distancePercent = Convert.ToInt32(data[8]);
            update_position_guages(distancePercent);
            sizePercent = Convert.ToInt32(data[9]);
            update_size_guages(sizePercent);

            // activate/inactivate tiles
            for (int i = 0; i < 8; i++)
            {
                setTileActivation(i, toBool(data[i]));
            }

            // set up game queue
            if (String.Compare(queue[0], "yes") == 0)
            {
                continuousChBx.Checked = true;
                populateQueueList(new Collection<string>(queue));
            }
            else
            {
                continuousList.Items.Clear();
                continuousChBx.Checked = false;
            }

        }

        private string generate_data_string()
        {
            string result = "";
            for (int i = 0; i < 8; i++)
            {
                if (tiles[i].on)
                {
                    result = result + "1 ";
                }
                else
                {
                    result = result + "0 ";
                }
            }
            result = result + distancePercent.ToString() + " " + sizePercent.ToString();
            return result;
        }

        private string generate_queue_string()
        {
            string result = "no";
            if (continuousChBx.Checked)
            {
                result = "yes";
                foreach (string direction in continuousList.Items)
                {
                    result = result + " " + directionsRevDict[direction];
                }
            }
            return result;
        }

        private void populateQueueList(Collection<string> queue)
        {
            continuousList.Items.Clear();
            foreach (string s in queue.Skip(1))
            {
                continuousList.Items.Add(directions[s]);
            }
        }

        private bool toBool(string value)
        {
            bool result = false;
            if (String.Compare(value, "1") == 0)
            {
                result = true;
            }
            return result;
        }

        private void levelSettingsChangeAction()
        {
            if (levelLoaded)
            {
                presetLevelsComboBox.SelectedIndex = -1;
                saveLevelBtn.Visible = true;
                removeLevelBtn.Visible = false;
            }
        }

        //private void levelNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (int)Keys.Enter)
        //    {
        //        levelSettingsChangeAction();
        //    }
        //}

        //private void levelNameTxtBox_Leave(object sender, EventArgs e)
        //{
        //    levelSettingsChangeAction();
        //}

        private void saveLevelBtn_Click(object sender, EventArgs e)
        {
            levelSettingsChangeAction();

            saveFormName = null;
            new saveSettingsForm().ShowDialog();

            if (saveFormName != null)
            {
                StreamWriter sw = new StreamWriter(userLevelsPath, true);
                sw.WriteLine(saveFormName);
                sw.WriteLine(generate_data_string());
                sw.WriteLine(generate_queue_string());
                sw.Close();

                // after saving level
                populatePresetLevelsBox();
                presetLevelsComboBox.SelectedIndex = presetLevelsComboBox.Items.Count - 1;
            }
        }

        public static bool uniqueName(string name)
        {
            bool result = true;
            StreamReader sr = new StreamReader(_assembly.GetManifestResourceStream(presetLevelsLocation));
            List<string> builtinLlevelNames = getLevelNames(sr);
            foreach (string s in builtinLlevelNames)
            {
                if (String.Compare(s, name) == 0)
                {
                    result = false;
                }
            }
            sr.Close();

            // get the user-defined presets second
            if (File.Exists(userLevelsPath))
            {
                StreamReader user = new StreamReader(userLevelsPath);
                List<string> userLevelNames = getLevelNames(user);
                foreach (string s in userLevelNames)
                {
                    if (String.Compare(s, name) == 0)
                    {
                        result = false;
                    }
                }
                user.Close();
            }
            return result;
        }

        private void removeLevelBtn_Click(object sender, EventArgs e)
        {
            char c;
            string line1 = "";
            //string line2 = "";
            //string line3 = "";

            int completed = 0;

            bool found = false;
            long lineStart;
            FileStream fs = new FileStream(userLevelsPath, FileMode.OpenOrCreate,
                  FileAccess.ReadWrite, FileShare.None);
            lineStart = fs.Position;
            while (fs.Length != fs.Position)
            {
                c = (char)fs.ReadByte();
                if (c == '\n')
                {
                    long tempPos = fs.Position;

                    if (completed == 0)
                    {
                        completed = 1;
                        if (String.Compare(presetLevelsComboBox.SelectedItem.ToString().Trim(), line1.Trim()) == 0)
                        {
                            found = true;
                        }
                        if (found)
                        {
                            fs.Position = lineStart;
                            fs.WriteByte((int)'/');
                        }
                        line1 = "";
                    }
                    else if (completed == 1)
                    {
                        completed = 2;
                        if (found)
                        {
                            fs.Position = lineStart;
                            fs.WriteByte((int)'/');
                        }
                    }
                    else if (completed == 2)
                    {
                        completed = 0;
                        if (found)
                        {
                            found = false;
                            fs.Position = lineStart;
                            fs.WriteByte((int)'/');
                        }
                    }

                    lineStart = tempPos;
                    fs.Position = tempPos;
                }
                else
                {
                    if (completed == 0)
                    {
                        line1 = line1 + c.ToString();
                    }
                }
            }
            //MessageBox.Show(line1);
            fs.Dispose();
            populatePresetLevelsBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            //Environment.Exit(1);
            //Application.Restart();
        }

    }
}
