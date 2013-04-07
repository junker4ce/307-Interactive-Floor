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
    public partial class Coordinate3 : Window
    {
        KinectSensor sensor;
        CaliTracking tracker;

        public Coordinate3(KinectSensor sensor, CaliTracking tracker)
        {
            this.sensor = sensor;
            this.tracker = tracker;
            InitializeComponent();
            this.WindowState = System.Windows.WindowState.Maximized;
            this.Loaded += new RoutedEventHandler(Coordinate3_Loaded);
            this.Unloaded += new RoutedEventHandler(Coordinate3_Unloaded);
        }

        private void setCoordinate3Click(object sender, RoutedEventArgs e)
        {
            Joint RightFoot = Calibration.mainSkeleton.Joints[JointType.FootRight];
            if (RightFoot == null) { }
            else
            {

                //App.xaxis.max = MatrixMath.jointToPoint(RightFoot);
                Debug.WriteLine("click");
                //MatrixMath.finalizeGrid();
                this.Close();
            }
        }

        void Coordinate3_Unloaded(object sender, RoutedEventArgs e)
        {
            //sensor.Stop();
            //sensor.SkeletonStream.Disable();
            Calibration.store();
        }

        void Coordinate3_Loaded(object sender, RoutedEventArgs e)
        {
            //sensor.SkeletonFrameReady += runtime_SkeletonFrameReady;
            //Tracker tracker = new Tracker(sensor);
            //sensor.Start();
            //sensor.ElevationAngle = -5;
        }
    }
}
