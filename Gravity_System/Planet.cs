using System;
using System.Collections.Generic;
using System.Text;

namespace Gravity_System
{
    public class Planet : Object
    {
        // Поля данных.
        private double radius;

        //Конструкторы.
        public Planet() { }

        public Planet(string planetName, double planetWeight, double planetRadius)
        {
            name = planetName;
            weight = planetWeight;
            radius = planetRadius;
        }

        //Методы.

        public override string ToString()
        {
            return "NAME: " + name.ToString() + " WEIGHT: " + weight.ToString() + " LOCATION: " + center.ToString();
        }
    }
}
