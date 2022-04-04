using CsCss.Values;
using CsCss.Values.Color;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.Line;

namespace CsCss.Properties.BorderColor
{
    public class DirectionalBorderColorValue : Value
    {
        public DirectionalBorderColorValue(string v) : base(v) { }

        public static implicit operator DirectionalBorderColorValue(GlobalKeyword value)
        {
            return new DirectionalBorderColorValue(value.ToString());
        }

        public static implicit operator DirectionalBorderColorValue(ColorValue value)
        {
            return new DirectionalBorderColorValue(value.ToString());
        }

        public static implicit operator DirectionalBorderColorValue(int value)
        {
            return new DirectionalBorderColorValue("#" + value.ToString("X"));
        }
    }
}
