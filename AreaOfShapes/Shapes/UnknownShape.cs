using AreaOfShapes.Сalculators.Area;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Shapes
{
    public class UnknownShape : Shape
    {
        public UnknownShape() : base(new NotCalculatedArea()) { }
    }
}
