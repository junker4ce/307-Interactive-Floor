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

        public Coordinate2(KinectSensor sensor)
        {
            InitializeComponent();
            this.sensor = sensor;
            this.Loaded += new RoutedEventHandler(Coordinate2_Loaded);
            this.Unloaded += new RoutedEventHandler(Coordinate2_Unloaded);
        }

        private void setCoordinate2Click(object sender, RoutedEventArgs e)
        {
            Coordinate3 coord3 = new Coordinate3(sensor);
            Point zero = new Point();
            App.xaxis.zero = zero;
            App.yaxis.zero = zero;
            coord3.Show();
            this.Close();

        }

        void Coordinate2_Unloaded(object sender, RoutedEventArgs e)
        {
            sensor.Stop();
        }

        void Coordinate2_Loaded(object sender, RoutedEventArgs e)
        {
            //sensor.SkeletonFrameReady += runtime_SkeletonFrameReady;
            sensor.Start();
            //sensor.ElevationAngle = -5;
        }
    }
}
