using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FigureMath
{
    /// <summary>Класс для описания enum</summary>
    public static class EnumDescriptionProvider
    {
        // С значения enum получаем описание
        public static string GetEnumDescription(Enum source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return source.ToString();
        }
    }
}
