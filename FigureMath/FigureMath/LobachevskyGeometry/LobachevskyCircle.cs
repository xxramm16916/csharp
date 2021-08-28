using System;
using System.Collections.Generic;
using System.Text;

namespace FigureMath.LobachevskyGeometry
{
    public class LobachevskyCircle : LobachevskyFigure
    {
        public LobachevskyCircle(string geometryType, string figureType) : base(geometryType, figureType)
        {
        }

        public double GetSquare(double radius)
        {
            return Math.Round(2 * 3.14d * ((Math.Pow(2.71d, radius) + Math.Pow(2.71d, -radius)) / 2d - 1), 1);
        }

    }
}
