using System;
using System.Collections.Generic;
using System.Text;

namespace Gravity_System
{
    public class Gravity
    {
        public static double F(Planet planet1, Planet planet2)
        {
            double result = 0;

            double G = Const.G;
            double R = Geometry.DistancesBetweenTwoPoints(planet1.center, planet2.center);

            return result = G * planet1.weight * planet2.weight / (R * R);
        }
    }
}
