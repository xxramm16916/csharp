using System;
using System.Collections.Generic;
using System.Text;

namespace FigureMath
{
    public abstract class Figure
    {
        public Figure (string geometryType)
        {
            GeometryFigureType = String.IsNullOrEmpty(geometryType) ? throw new Exception("Ошибка задания типа геометрии.") : geometryType;
        }

        public string GeometryFigureType { get; private set; }
    }
}
