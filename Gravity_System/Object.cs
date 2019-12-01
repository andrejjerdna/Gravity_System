using System;
using System.Collections.Generic;
using System.Text;

namespace Gravity_System
{
    public class Object
    {
        public string name = "Object";
        public double weight = 0;
        public double speed = 0;

        public Point center { get; set; } = new Point();
    }
}
