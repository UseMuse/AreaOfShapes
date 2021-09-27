using AreaOfShapes.Сalculators.Area;
using System;

namespace AreaOfShapes.Shapes
{
    public abstract class Shape
    {
        readonly AreaInfo method;
        public Shape(AreaInfo method)
        {
            this.method = method;
        }

        public double? Area()
        {
            return method.Info(this);
        }
    }
}
