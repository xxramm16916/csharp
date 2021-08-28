using FigureMath;
using FigureMath.Enums;
using FigureMath.EuclideanGeometry;
using FigureMath.LobachevskyGeometry;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var euclideanTriangle = (EuclideanTriangle)FiguresFactory.GetGeometryFiugure((int)GeometryTypes.EuclidianGeometry, (int)FigureTypes.Triangle);
            Console.WriteLine("Площадь евклидова треугольника = " + euclideanTriangle.GetSquare(5, 5, 8));
            Console.WriteLine("Треугольник прямоугольный = " + euclideanTriangle.IsStraightTriangle(6, 8, 10));

            var euclideanCirkl = (EuclideanCircle)FiguresFactory.GetGeometryFiugure((int)GeometryTypes.EuclidianGeometry, (int)FigureTypes.Circle);
            Console.WriteLine("Площадь евклидова круга = " + euclideanCirkl.GetSquare(5));

            var lobachevskyTriangle = (LobachevskyTriangle)FiguresFactory.GetGeometryFiugure((int)GeometryTypes.LobachevskyGeometri, (int)FigureTypes.Triangle);
            Console.WriteLine("Площадь треугольника лобачевского = " + lobachevskyTriangle.GetSquare(5, 0.1, 0.3, 0.5));

            var lobachevskyCirkl = (LobachevskyCircle)FiguresFactory.GetGeometryFiugure((int)GeometryTypes.LobachevskyGeometri, (int)FigureTypes.Circle);
            Console.WriteLine("Площадь круга лобачевского = " + lobachevskyCirkl.GetSquare(5));

            Console.ReadKey();
        }
    }
}
