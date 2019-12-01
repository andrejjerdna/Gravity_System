using System;
using System.Collections.Generic;
using System.Text;

namespace Gravity_System
{
    class Vector : Point
    {
        public Vector() { }

        public Vector(double valueX, double valueY, double valueZ)
        {
            X = valueX;
            Y = valueY;
            Z = valueZ;
        }

        public Vector(Point point)
        {
            X = point.X;
            Y = point.Y;
            Z = point.Z;
        }
    }
}
