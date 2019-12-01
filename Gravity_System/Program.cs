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
          

            Planet n = new Planet("", 300, 300);
            n.center = new Point();

            Planet n2 = new Planet("", 3100000, 300);
            n2.center = new Point(10, 0, 0);

            double F = Gravity.F(n, n2);

            Console.WriteLine(F.ToString());
            Console.ReadKey();
        }
    }
}
