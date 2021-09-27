using AreaOfShapes.Сalculators.Area;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Shapes
{
    public class Triangle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c, AreaInfo method) : base(method)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");

            A = a; B = b; C = c;
        }
        public bool IsRightAngled()
        {
            return (A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A);
        }
    }
}


