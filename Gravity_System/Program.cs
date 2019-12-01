using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravity_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Geometry.DistancesBetweenTwoPoints(new Point(0, 555, 0), new Point(0, 0, 0));

            Console.WriteLine(r.ToString());

            Console.ReadKey();
        }
    }
}
