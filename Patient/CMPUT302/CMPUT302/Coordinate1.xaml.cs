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
        KinectSensor sensor;

        public Coordinate1(KinectSensor sensor)
        {
            InitializeComponent();
            this.sensor = sensor;
            this.Loaded += new RoutedEventHandler(Coordinate1_Loaded);
            this.Unloaded += new RoutedEventHandler(Coordinate1_Unloaded);
        }

        private void setCoordinate1Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Point YMax = new Point();
            App.xaxis.zero = YMax;
            App.yaxis.zero = YMax;
            main.Show();
            this.Close();

        }

        void Coordinate1_Unloaded(object sender, RoutedEventArgs e)
        {
            sensor.Stop();
        }

        void Coordinate1_Loaded(object sender, RoutedEventArgs e)
        {
            //sensor.SkeletonFrameReady += runtime_SkeletonFrameReady;
            sensor.Start();
            //sensor.ElevationAngle = -5;
        }
    }
}
