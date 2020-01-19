using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUSB_ProgressViewer.Models;

namespace TUSB_ProgressViewer.Util
{
    public static class EnumExtension
    {
        /// <summary>
        /// 島の名前
        /// </summary>
        [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
        public sealed class NameAttribute : Attribute
        {
            public string Name { get; private set; }

            public NameAttribute(string name)
            {
                Name = name;
            }
        }

        /// <summary>
        /// 島のディメンション
        /// </summary>
        [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
        public sealed class DimensionAttribute : Attribute
        {
            public IslandDimension Dimension { get; private set; }

            public DimensionAttribute(IslandDimension dimension)
            {
                Dimension = dimension;
            }
        }

        /// <summary>
        /// 島の座標
        /// </summary>
        [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
        public sealed class CoordinateAttribute : Attribute
        {
            public int X { get; private set; }
            public int Y { get; private set; }
            public int Z { get; private set; }

            public CoordinateAttribute(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

        public static string GetName(this Enum value) => value.GetAttribute<NameAttribute>()?.Name ?? value.ToString();

        public static IslandDimension GetDimension(this Enum value) => value.GetAttribute<DimensionAttribute>()?.Dimension ?? IslandDimension.Overworld;

        public static (int X, int Y, int Z) GetCoordinate(this Enum value)
            => (value.GetAttribute<CoordinateAttribute>()?.X ?? 0, value.GetAttribute<CoordinateAttribute>()?.Y ?? 0, value.GetAttribute<CoordinateAttribute>()?.Z ?? 0);

        private static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var info = value.GetType().GetField(value.ToString());

            var attrs = info.GetCustomAttributes(typeof(T), false).Cast<T>();

            return attrs.Count() > 0 ? attrs.First() : null;
        }
    }
}
