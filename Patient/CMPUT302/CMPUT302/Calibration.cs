using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace CMPUT302
{
    class Calibration
    {
        public static Skeleton mainSkeleton = new Skeleton();
        public static Axis xaxis = new Axis();
        public static Axis yaxis = new Axis();

        public static void start()
        {
            CaliTracking tracking = new CaliTracking();
            Coordinate1 cali = new Coordinate1();
            cali.Show();
        }
    }
}
