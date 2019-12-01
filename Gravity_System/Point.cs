using System;
using System.Collections.Generic;
using System.Text;

namespace Gravity_System
{
    public class Point
    {
        public double X;
        public double Y;
        public double Z;

        public Point() { }

        public Point(double valueX, double valueY, double valueZ)
        {
            X = valueX;
            Y = valueY;
            Z = valueZ;
        }

        public override string ToString()
        {
            return $"{X:0.0000}, {Y:0.0000}, {Z:0.0000}";
        }
    }
}
