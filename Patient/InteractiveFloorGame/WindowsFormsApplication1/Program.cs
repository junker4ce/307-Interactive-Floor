using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InteractiveFloorGame
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
        }
        public void Game()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlForm());
        }
    }
}
