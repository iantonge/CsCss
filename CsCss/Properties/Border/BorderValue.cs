using CsCss.Values;
using CsCss.Values.Color;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.Line;

namespace CsCss.Properties.Border
{
    public class BorderValue : Value
    {
        public BorderValue(string v) : base(v) { }

        public static implicit operator BorderValue(GlobalKeyword value)
        {
            return new BorderValue(value.ToString());
        }

        public static implicit operator BorderValue(LineWidthValue value)
        {
            return new BorderValue(value.ToString());
        }

        public static implicit operator BorderValue(LengthValue value)
        {
            return new BorderValue(value.ToString());
        }

        public static implicit operator BorderValue(LineStyleValue value)
        {
            return new BorderValue(value.ToString());
        }

        public static implicit operator BorderValue(NoneKeyword value)
        {
            return new BorderValue(value.ToString());
        }

        public static implicit operator BorderValue(ColorValue value)
        {
            return new BorderValue(value.ToString());
        }

        public static implicit operator BorderValue(int value)
        {
            return new BorderValue("#" + value.ToString("X"));
        }

        public static implicit operator BorderValue((LineWidthValue width, LineStyleValue style) value)
        {
            return new BorderValue(value.width.ToString() + " " + value.style.ToString());
        }

        public static implicit operator BorderValue((LineWidthValue width, ColorValue color) value)
        {
            return new BorderValue(value.width.ToString() + " " + value.color.ToString());
        }

        public static implicit operator BorderValue((LineWidthValue width, LineStyleValue style, ColorValue color) value)
        {
            return new BorderValue(value.width.ToString() + " " + value.style.ToString() + " " + value.color.ToString());
        }

        public static implicit operator BorderValue((LineStyleValue style, ColorValue color) value)
        {
            return new BorderValue(value.style.ToString() + " " + value.color.ToString());
        }
    }
}
