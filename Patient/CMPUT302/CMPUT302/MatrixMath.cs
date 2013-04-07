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
            
            //Calculate the distance the foot is from the floor
            double D = ((a*x)+(b*y)+(c*x)+d);
            //double denom = Math.Sqrt(Math.Pow(a, 2.0)+Math.Pow(b,2.0)+Math.Pow(c,2.0));

            if (D < 0.01)
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
            //double denom = Math.Sqrt(Math.Pow(a, 2.0)+Math.Pow(b,2.0)+Math.Pow(c,2.0));

            return Dfull;
        }

    }
}
