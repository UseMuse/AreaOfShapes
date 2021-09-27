using AreaOfShapes.Сalculators.Area;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Shapes
{
    public class Circle : Shape
    {        
        /// <summary> Радиус круга </summary>
        public double Radius { get; private set; }

        public Circle(double radius, AreaInfo method)
            : base(method)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

            this.Radius = radius;
        }
    }
}
