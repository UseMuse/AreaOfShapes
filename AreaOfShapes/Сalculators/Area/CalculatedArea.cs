using AreaOfShapes.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Сalculators.Area
{
    public class CalculatedArea : AreaInfo
    {
        public override double? Info(Shape shape)
        {
            double? value;
            if (shape is Circle) { var c = shape as Circle; value = Math.PI * Math.Pow(c.Radius, 2); }
            else if (shape is Triangle)
            {
                var c = shape as Triangle;
                double p = (c.A + c.B + c.C) / 2;
                value = Math.Sqrt(p * (p - c.A) * (p - c.B) * (p - c.C));
            }
            else if (shape is UnknownShape)
            {
                value = null;
            }
            else
            {
                throw new NotImplementedException($"Отсутствует реализация рассчёта площади для фигуры типа {shape.GetType()}");
            }
            return value;
        }
    }
}
