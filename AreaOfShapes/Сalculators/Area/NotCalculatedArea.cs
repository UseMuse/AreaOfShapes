using AreaOfShapes.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Сalculators.Area
{
    public class NotCalculatedArea : AreaInfo
    {
        public override double? Info(Shape shape)
        {
            return null;
        }
    }
}
