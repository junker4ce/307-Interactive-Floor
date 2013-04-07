using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Microsoft.Kinect;

namespace CMPUT302
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static String joint = "Left";
        public readonly static int XPIXEL = 1366;
        public readonly static int YPIXEL = 768;
        public static Axis xaxis = new Axis();
        public static Axis yaxis = new Axis();
        public static Skeleton mainSkeleton = new Skeleton();
        public static bool donecal;
    }
}
