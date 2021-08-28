using FigureMath;
using FigureMath.Enums;
using FigureMath.EuclideanGeometry;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.EuclideanGeometry
{
    public class EuaclidianTriangleTests
    {
        [Theory]
        [InlineData(1, 1, 1, 0.4)]
        [InlineData(2, 2.5, 1, 0.9)]
        public void EuaclidianTriangleSquarte_CorrectData_Success(double sideA, double sideB, double sideC, double result)
        {
            // Arrange
            var euclideanTriangle = (EuclideanTriangle)FiguresFactory.GetGeometryFiugure((int)GeometryTypes.EuclidianGeometry, (int)FigureTypes.Triangle);

            // Act
            var square = euclideanTriangle.GetSquare(sideA, sideB, sideC);

            //Assert
            Assert.True(square == result);
        }

        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void EuaclidianTriangleSquarte_WrondData_ThrowException(double sideA, double sideB, double sideC)
        {
            // Arrange
            var euclideanTriangle = (EuclideanTriangle)FiguresFactory.GetGeometryFiugure((int)GeometryTypes.EuclidianGeometry, (int)FigureTypes.Triangle);

            // Act
            Action act = null;
            act = () => euclideanTriangle.GetSquare(sideA, sideB, sideC);

            //Assert
            Assert.ThrowsAny<Exception>(act);
        }
    }
}
