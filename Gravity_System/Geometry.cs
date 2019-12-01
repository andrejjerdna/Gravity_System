using System;
using System.Collections.Generic;
using System.Text;

namespace Gravity_System
{
    public class Geometry
    {
        /// <summary>
        /// Расстояние между двумя точками.
        /// </summary>
        /// <param name="p1">Точка 1.</param>
        /// <param name="p2">Точка 2.</param>
        /// <returns></returns>
        public static double DistancesBetweenTwoPoints(Point p1, Point p2)
        {
            double tX = Math.Pow((p1.X - p2.X), 2);
            double tY = Math.Pow((p1.Y - p2.Y), 2);
            double tZ = Math.Pow((p1.Z - p2.Z), 2);

            return Math.Sqrt(tX + tY + tZ);
        }
    }
}
