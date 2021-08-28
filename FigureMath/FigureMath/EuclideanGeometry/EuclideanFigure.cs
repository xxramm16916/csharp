using System;
using System.Collections.Generic;
using System.Text;

namespace FigureMath.EuclideanGeometry
{
    public abstract class EuclideanFigure : Figure
    {
        public EuclideanFigure(string geometryType, string figureType) : base(geometryType)
        {
            FigureType = String.IsNullOrEmpty(figureType) ? throw new Exception("Ошибка задания типа фигуры.") : figureType;
        }

        public string FigureType { get; private set; }
    }
}
