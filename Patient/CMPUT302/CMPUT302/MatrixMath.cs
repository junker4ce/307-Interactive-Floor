using System;
using System.Collections.Generic;
using Microsoft.Kinect;
using System.Linq;
using System.Text;

namespace CMPUT302
{
    //Class to preform nessicary matrix mathmatics
    public class MatrixMath
    {
        //boolean is foot touching floor
        public static bool FootToFloor(Tuple<float, float, float, float> FloorClipPlane, Joint point)
        {
            double a = System.Convert.ToDouble(FloorClipPlane.Item1);
            double b = System.Convert.ToDouble(FloorClipPlane.Item2);
            double c = System.Convert.ToDouble(FloorClipPlane.Item3);
            double d = System.Convert.ToDouble(FloorClipPlane.Item4);
            float x = point.Position.X;
            float y = point.Position.Y;
            float z = point.Position.Z;

            //Debug.WriteLine(x + " " + y);
            //Calculate the distance the foot is from the floor
            double D = ((a * x) + (b * y) + (c * x) + d);
            double denom = Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0) + Math.Pow(c, 2.0));

            if (D / denom < 0.2)
                return true;

            return false;
        }

        //actual distance value for testing and calibration
        public static double FootToFloorVal(Tuple<float, float, float, float> FloorClipPlane, Joint point)
        {
            double a = System.Convert.ToDouble(FloorClipPlane.Item1);
            double b = System.Convert.ToDouble(FloorClipPlane.Item2);
            double c = System.Convert.ToDouble(FloorClipPlane.Item3);
            double d = System.Convert.ToDouble(FloorClipPlane.Item4);
            float x = point.Position.X;
            float y = point.Position.Y;
            float z = point.Position.Z;


            double Dfull = ((a * x) + (b * y) + (c * x) + d);
            double denom = Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0) + Math.Pow(c, 2.0));

            return Dfull / denom;
        }

        //public static double distance(Point foot, Axis axis)
        //{
        //    Point c = pointSub(axis.max, axis.zero);
        //    Point a = pointSub(foot, axis.zero);
        //    Point b = pointSub(foot, axis.max);
        //    Point num = crossProduct(a, b);
        //    return vectorval(num) / vectorval(c);
        //}

        //        public static void finalizeGrid()
        //        {
        //            .xaxis.distance = distance(App.xaxis.max, App.yaxis);
        //            .xaxis.resolution = App.XPIXEL;
        //            App.yaxis.distance = distance(App.yaxis.max, App.xaxis);
        //            App.yaxis.resolution = App.YPIXEL;
        //            return;
        //        }

        public static Point jointToPoint(Joint joint)
        {
            Point transpoint = new Point();
            transpoint.x = joint.Position.X;
            transpoint.y = joint.Position.Y;
            transpoint.z = joint.Position.Z;
            return transpoint;
        }
    }
}

//        private static Point pointSub(Point a, Point b)
//        {
//            Point sub = new Point();
//            sub.x = a.x - b.x;
//            sub.y = a.y - b.y;
//            sub.z = a.z - b.z;
//            return sub;
//        }

//        private static double vectorval(Point point)
//        {
//            return Math.Sqrt(Math.Pow(point.x, 2.0) + Math.Pow(point.y, 2.0) + Math.Pow(point.z, 2.0));
//        }

//        private static Point crossProduct(Point a, Point b)
//        {
//            Point product = new Point();
//            product.x = ((a.y * b.z) - (a.z * b.y));
//            product.y = ((a.z * b.x) - (a.x * b.z));
//            product.z = ((a.x * b.y) - (a.y * b.x));
//            return product;
//        }

//        public static int distToRes(double dist, Axis axis)
//        {
//            return Convert.ToInt32((axis.resolution * dist) / axis.distance);
//        }
//    }
//}