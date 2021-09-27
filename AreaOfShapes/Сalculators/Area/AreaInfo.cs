using AreaOfShapes.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes.Сalculators.Area
{
    /// <summary> Класс отвечающий за получение информации о площади фигуры </summary>
    public abstract class AreaInfo
    {
        public abstract double? Info(Shape shape);
    }
}
