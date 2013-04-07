using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Kinect;

namespace CMPUT302
{
    public class CaliTracking
    {
        public Skeleton[] skeletons = null;
        public MainWindow MWindow;
        public Tuple<float, float, float, float> FloorClipPlane { get; private set; }
        KinectSensor sensor = KinectSensor.KinectSensors[0];

        public CaliTracking()
        {
            var smoothing = new TransformSmoothParameters
            {
                Smoothing = 0.2f,
                Correction = 0.0f,
                Prediction = 0.0f,
                JitterRadius = 1.0f,
                MaxDeviationRadius = 0.5f
            };
            sensor.SkeletonFrameReady += SensorSkeletonFrameReady;
            sensor.SkeletonStream.Enable(smoothing);
        }
        private void SensorSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            // Access the skeleton frame
            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    if (this.skeletons == null)
                    {
                        // Allocate array of skeletons
                        this.skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                        
                    }

                    // Copy skeletons from this frame
                    skeletonFrame.CopySkeletonDataTo(this.skeletons);

                    // Find first tracked skeleton, if any
                    Skeleton skeleton = this.skeletons.Where(s => s.TrackingState == SkeletonTrackingState.Tracked).FirstOrDefault();
                    FloorClipPlane = skeletonFrame.FloorClipPlane;
                    //Debug.WriteLine(skeletonFrame.FloorClipPlane);

                    if (skeleton != null)
                    {
                        // Obtain the left knee joint; if tracked, print its position

                      
                       Calibration.mainSkeleton = skeleton;
                       Debug.WriteLine(skeleton.Joints[JointType.FootLeft].Position.X + " " + skeleton.Joints[JointType.FootLeft].Position.Y + " " + skeleton.Joints[JointType.FootLeft].Position.Z);
                    }
                }
            }
        }
    }
}
