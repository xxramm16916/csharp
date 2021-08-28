using System;
using System.Collections.Generic;
using System.Text;

namespace FigureMath.LobachevskyGeometry
{
    public abstract class LobachevskyFigure : Figure
    {
        public LobachevskyFigure(string geometryType, string figureType) : base(geometryType)
        {
            FigureType = String.IsNullOrEmpty(figureType) ? throw new Exception("Ошибка задания типа фигуры.") : figureType;
        }

        public string FigureType { get; private set; }
    }
}
