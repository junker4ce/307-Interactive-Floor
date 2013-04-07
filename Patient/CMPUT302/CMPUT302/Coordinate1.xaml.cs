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
    public partial class Coordinate1 : Window
    {
        KinectSensor sensor = KinectSensor.KinectSensors[0];
        CaliTracking tracker = new CaliTracking();

        public Coordinate1()
        {
            InitializeComponent();
            this.WindowState = System.Windows.WindowState.Maximized;
            var smoothing = new TransformSmoothParameters
            {
                Smoothing = 0.2f,
                Correction = 0.0f,
                Prediction = 0.0f,
                JitterRadius = 1.0f,
                MaxDeviationRadius = 0.5f
            };
            this.Loaded += new RoutedEventHandler(Coordinate1_Loaded);
            this.Unloaded += new RoutedEventHandler(Coordinate1_Unloaded);
        }

        private void setCoordinate1Click(object sender, RoutedEventArgs e)
        {
            Joint LeftFoot = Calibration.mainSkeleton.Joints[JointType.FootLeft];
            if (LeftFoot == null) { }
            else
            {
                Calibration.yaxis.max = MatrixMath.jointToPoint(LeftFoot);
                Coordinate2 coord2 = new Coordinate2(sensor, tracker);
                Debug.WriteLine("click");
                coord2.Show();
                this.Close();
            }

        }

        void Coordinate1_Unloaded(object sender, RoutedEventArgs e)
        {
        }

        void Coordinate1_Loaded(object sender, RoutedEventArgs e)
        {
            //Kinect.sensor.SkeletonFrameReady += runtime_SkeletonFrameReady;
            sensor.Start();
            //sensor.ElevationAngle = 0;
        }
    }
}
