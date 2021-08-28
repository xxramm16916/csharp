using System;
using System.Collections.Generic;
using System.Text;

namespace FigureMath.LobachevskyGeometry
{
    public class LobachevskyTriangle : LobachevskyFigure
    {
        public LobachevskyTriangle(string geometryType, string figureType) : base(geometryType, figureType)
        {
        }

        public double GetSquare(double radius, double A, double B, double C)
        {
            Validate(A, B, C);
            return Math.Round(Math.Pow(radius, 2) * (3.14d - A - B - C), 1, MidpointRounding.AwayFromZero);
        }

        private void Validate(double A, double B, double C)
        {
            if (A < 0 || B < 0 || C < 0)
                throw new Exception("Углы должны быть больше нуля.");
            else if (A + B + C >= 3.14d)
                throw new Exception("Сумма углов евклидова треугольника должна быть меньше pi.");
        }
    }
}
