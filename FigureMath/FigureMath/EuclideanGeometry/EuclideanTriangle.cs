using System;
using System.Collections.Generic;
using System.Text;

namespace FigureMath.EuclideanGeometry
{
    public class EuclideanTriangle : EuclideanFigure
    {
        public EuclideanTriangle(string geometryType, string figureType) : base(geometryType, figureType)
        {
        }

        public double GetSquare(double sideA, double sideB, double sideC)
        {
            Validate(sideA, sideB, sideC);

            var perimeter = (sideA + sideB + sideC) / 2;
            var square = Math.Round(Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC)), 1, MidpointRounding.AwayFromZero);
            return square;
        }

        private void Validate(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
                throw new Exception("Одна из сторон меньше нуля");
            else if (sideA > (sideB + sideC) || sideB > (sideA + sideC) || sideC > (sideA + sideB))
                throw new Exception("Сторона больше суммы двух других");
        }


        public bool IsStraightTriangle(double sideA, double sideB, double sideC)
        {
            Validate(sideA, sideB, sideC);

            return sideA == Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideC, 2))
                || sideB == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideC, 2))
                || sideC == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }
    }
}
