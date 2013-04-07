using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Kinect;

namespace CMPUT302
{
    class Calibration
    {
        //public static Skeleton mainSkeleton = new Skeleton();
        public static Axis xaxis = new Axis();
        public static Axis yaxis = new Axis();
        public static Skeleton mainSkeleton = new Skeleton();

        public static void start()
        {
            CaliTracking tracking = new CaliTracking();
            Coordinate1 cali = new Coordinate1();
            cali.Show();
        }

        public static void store()
        {
            TextWriter output = new StreamWriter("calibration.txt");
            output.WriteLine(xaxis.max);
            output.WriteLine(yaxis.max);
            output.WriteLine(xaxis.zero);
            output.WriteLine(xaxis.distance);
            output.WriteLine(yaxis.distance);
        }
    }
}
