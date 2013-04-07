using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace CMPUT302
{
    //stores position of previous mouse click and provides funcionality
    public class Position
    {
        double X;
        double Z;
        private const double calibrationX = 0.05;
        private const double calibrationZ = 0.05;

        public bool SamePosition(Joint newFoot)
        {
            if (PositionMathX(newFoot) < calibrationX && PositionMathZ(newFoot) < calibrationZ)
            {
                return true;
            }
            return false;
        }

        private double PositionMathX(Joint newFoot)
        {
            return Math.Abs(newFoot.Position.X - X);
        }
        private double PositionMathZ(Joint newFoot)
        {
            return Math.Abs(newFoot.Position.Z - Z);
        }
        
        public void setX (double X)
        {
            this.X = X;
            return;
        }

        public void setZ(double Z)
        {
            this.Z = Z;
            return;
        }
    }
}
