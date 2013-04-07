using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using InteractiveFloorGame.Properties;

namespace InteractiveFloorGame
{
    public partial class GameForm : Form
    {
        int game_time_limit = 0;
        int game_time = 0;
        int tempScore = 0;
        int maxScore = 0;
        int currentStep = 0;

        public bool continuousStyle;

        public Button[] buttons;

        public string[] queue;


        public GameForm(int time, string[] continuousQueue)
        {
            InitializeComponent();

            queue = continuousQueue;

            buttons = new Button[] { button2, button3, button4, button5, button6, button7, button8, button1 };

            init_game();

            // game timer
            game_time_limit = time;
            countdown.Text = game_time_limit.ToString();
            gametimer.Interval = 1000;
            gametimer.Start();
        }

        public void init_game()
        {
            // what type of game?
            continuousStyle = false;
            if (queue[currentStep] == "yes")
            {
                continuousStyle = true;
                currentStep++;
            }

            maxScore = 0;
            resize_gameplay();
            for (int i = 0; i < 8; i++)
            {
                if (ControlForm.tiles[i].on)
                {
                    //buttons[i].Size = Form1.tiles[i].size;
                    //buttons[i].Location = Form1.tiles[i].location;
                    buttons[i].Image = ControlForm.tiles[i].get_image(buttons[i].Size);

                    maxScore++;
                }
                else
                {
                    buttons[i].Hide();
                }
            }

            tempScore = 0;
            scoreDisplay.Text = tempScore.ToString();
        }

        public void endGame()
        {
            if (ControlForm.currentPatient != null)
            {
                // finalize game data
                ControlForm.currentPatient.gameScore = tempScore;
                ControlForm.currentPatient.outOf = maxScore;
                ControlForm.currentPatient.time = game_time;
                ControlForm.currentPatient.foot = ControlForm.currentFoot;

                // write score to file
                StreamWriter sw = new StreamWriter(ControlForm.currentPatient.filePath,true);
                string line = "";
                
                line = ControlForm.currentPatient.get_data();
                sw.WriteLine(line);

                sw.Close();

                // reset patient for next game
                ControlForm.currentPatient.gameScore = 0;
            }

            this.Close();
        }

        public void resize_gameplay()
        {
            double s = ControlForm.sizePercent;
            for (int i = 0; i < 8; i++)
            {
                buttons[i].Height = Convert.ToInt32((s / 100) * (game_panel.Height / 2));
                buttons[i].Width = Convert.ToInt32((s / 100) * (game_panel.Height / 2));
                buttons[i].Location = ControlForm.calc_position(i + 1, buttons[i].Size, ControlForm.distancePercent, game_panel.Height, new Point(game_panel.Width/2, game_panel.Height / 2));
                buttons[i].Image = ControlForm.tiles[i].get_image(buttons[i].Size);
            }
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            game_time += 1;

            countdown.Text = (game_time_limit-game_time).ToString();

            if (game_time >= game_time_limit)
            {
                gametimer.Stop();
                endGame();
                //this.Close();
            }
        }

        private void gameTileClick(int index)
        {
            if (continuousStyle)
            {
                // continuous "DDR" style game
                if (!ControlForm.tiles[index].stepped)
                {
                    if (index == Convert.ToInt32(queue[currentStep]))
                    {
                        currentStep++;
                        tempScore++;
                        scoreDisplay.Text = tempScore.ToString();
                        ControlForm.tiles[index].image = Resources.img_blueBalloon;
                        buttons[index].Image = ControlForm.tiles[index].get_image(buttons[index].Size);
                        if (currentStep >= queue.Count())
                        {
                            endGame();
                        }
                        else
                        {
                            ControlForm.tiles[Convert.ToInt32(queue[currentStep])].image = Resources.img_yellowBalloon;
                            buttons[Convert.ToInt32(queue[currentStep])].Image = ControlForm.tiles[Convert.ToInt32(queue[currentStep])].get_image(buttons[Convert.ToInt32(queue[currentStep])].Size);
                        }
                    }
                }
            }
            else
            {
                // Pop targets once each style of game
                if (!ControlForm.tiles[index].stepped)
                {
                    ControlForm.tiles[index].stepped = true;
                    tempScore++;
                    scoreDisplay.Text = tempScore.ToString();
                    ControlForm.tiles[index].image = Resources.img_bluePoppedBalloon;
                    buttons[index].Image = ControlForm.tiles[index].get_image(buttons[index].Size);
                    //buttons[index].BackColor = Form1.pressedColour;

                    if (tempScore >= maxScore)
                    {
                        endGame();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameTileClick(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameTileClick(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameTileClick(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gameTileClick(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gameTileClick(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gameTileClick(5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gameTileClick(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameTileClick(7);
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            resize_gameplay();
        }

        private void GameForm_Shown(object sender, EventArgs e)
        {
            if (currentStep >= queue.Count())
            {
                endGame();
            }
        }

    }
}
