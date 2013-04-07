using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Microsoft.Kinect;
using System.Windows.Forms;
using System.Diagnostics;

namespace CMPUT302
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    static class App
    {
        //public static String joint = "Left";
        //public readonly static int XPIXEL = 1366;
        //public readonly static int YPIXEL = 768;
        //public static Axis xaxis = new Axis();
        //public static Axis yaxis = new Axis();
        //public static Skeleton mainSkeleton = new Skeleton();
        //public static bool donecal;

        static void Main()
        {
            Debug.WriteLine("Main Function");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
