using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InteractiveFloorGame
{
    public class PatientProfile
    {
        public PatientProfile() { }

        public PatientProfile(string path)
        {
            filePath = path;
            
            StreamReader sr = new StreamReader(path);
            name = sr.ReadLine();
            //sr.ReadLine();    

            sr.Close();
        }

        public string filePath = "";
        public string name = "";

        public int gameNumber = 1;
        public int gameScore = 0;
        public int outOf = 0;
        public int time = 0;
        public ControlForm.feet foot = ControlForm.feet.FootRight;

        public string get_data()
        {
            string line = gameNumber.ToString() + "|" + gameScore.ToString() + "|" + outOf.ToString() 
                + "|" + time.ToString() + "|" + foot.ToString();
            return line;
        }
    }
}
