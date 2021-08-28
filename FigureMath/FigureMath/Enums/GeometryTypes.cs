using System.ComponentModel;

namespace FigureMath.Enums
{
    /// <summary>Типы геометрий, которые существуют в библиотеке</summary>
    public enum GeometryTypes
    {
        [Description("Евклидова геометрия")]
        EuclidianGeometry = 1,

        [Description("Геометрия лобачевского")]
        LobachevskyGeometri = 2
    }
}
