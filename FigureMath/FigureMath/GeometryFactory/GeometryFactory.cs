using FigureMath.Enums;
using FigureMath.EuclideanGeometry;
using FigureMath.LobachevskyGeometry;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FigureMath
{
    public static class FiguresFactory
    {
        public static Figure GetGeometryFiugure(int geometryType, int figureType)
        {
            if (geometryType == (int)GeometryTypes.EuclidianGeometry)
            {
                switch (figureType)
                {
                    case (int)FigureTypes.Triangle:
                        return new EuclideanTriangle(EnumDescriptionProvider.GetEnumDescription((GeometryTypes)geometryType), EnumDescriptionProvider.GetEnumDescription((GeometryTypes)figureType));
                    case (int)FigureTypes.Circle:
                        return new EuclideanCircle(EnumDescriptionProvider.GetEnumDescription((GeometryTypes)geometryType), EnumDescriptionProvider.GetEnumDescription((GeometryTypes)figureType));
                    default:
                        throw new Exception("Вы хотите в другие фигуры?? Тогда отправьте смс)))");
                }
            }
            else if (geometryType == (int)GeometryTypes.LobachevskyGeometri)
            {
                switch (figureType)
                {
                    case (int)FigureTypes.Triangle:
                        return new LobachevskyTriangle(EnumDescriptionProvider.GetEnumDescription((GeometryTypes)geometryType), EnumDescriptionProvider.GetEnumDescription((GeometryTypes)figureType));
                    case (int)FigureTypes.Circle:
                        return new LobachevskyCircle(EnumDescriptionProvider.GetEnumDescription((GeometryTypes)geometryType), EnumDescriptionProvider.GetEnumDescription((GeometryTypes)figureType));
                    default:
                        throw new Exception("Вы хотите в другие фигуры?? Тогда отправьте смс)))");
                }
            }
            else
            {
                throw new Exception("Вы хотите в другие геометрии?? Тогда отправьте смс)))");
            }
        }
    }
}
