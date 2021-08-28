using System;
using System.Collections.Generic;
using System.Text;

namespace FigureMath.EuclideanGeometry
{
    public class EuclideanCircle : EuclideanFigure
    {
        public EuclideanCircle(string geometryType, string figureType) : base(geometryType, figureType)
        {
        }

        public double GetSquare(double radius)
        {
            Validate(radius);
            return Math.Round(3.14d * Math.Pow(radius, 2), 1, MidpointRounding.AwayFromZero);
        }

        private void Validate(double radius)
        {
            if (radius < 0)
                throw new Exception("Радиус меньше нуля");
        }
    }
}
