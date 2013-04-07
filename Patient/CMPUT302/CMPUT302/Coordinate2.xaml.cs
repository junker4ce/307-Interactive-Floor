using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Kinect;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;



namespace CMPUT302
{
    //Partially completed calibration class
    public partial class Coordinate2 : Window
    {
        KinectSensor sensor;
        CaliTracking tracker;

        public Coordinate2(KinectSensor sensor, CaliTracking tracker)
        {
            this.sensor = sensor;
            this.tracker = tracker;
            InitializeComponent();
            this.WindowState = System.Windows.WindowState.Maximized;
            this.Loaded += new RoutedEventHandler(Coordinate2_Loaded);
            this.Unloaded += new RoutedEventHandler(Coordinate2_Unloaded);
        }

        private void setCoordinate2Click(object sender, RoutedEventArgs e)
        {
            Joint LeftFoot = App.mainSkeleton.Joints[JointType.FootLeft];
            if (LeftFoot == null) { }
            else
            {
                Point zero = MatrixMath.jointToPoint(LeftFoot);
                Calibration.yaxis.zero = zero;
                Calibration.xaxis.zero = zero;
                Debug.WriteLine("click");
                Coordinate3 coord3 = new Coordinate3(sensor, tracker);
                coord3.Show();
                this.Close();
            }

        }

        void Coordinate2_Unloaded(object sender, RoutedEventArgs e)
        {
            //sensor.Stop();
        }

        void Coordinate2_Loaded(object sender, RoutedEventArgs e)
        {
            //Kinect.sensor.SkeletonFrameReady += runtime_SkeletonFrameReady;
            //Tracker tracker = new Tracker(sensor);
            //sensor.Start();
            //sensor.ElevationAngle = 0;
        }
    }
}
