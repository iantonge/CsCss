using CsCss.Values;
using CsCss.Values.Color;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.Line;

namespace CsCss.Properties.BorderColor
{
    public class BorderColorValue : Value
    {
        public BorderColorValue(string v) : base(v) { }

        public static implicit operator BorderColorValue(GlobalKeyword value)
        {
            return new BorderColorValue(value.ToString());
        }

        public static implicit operator BorderColorValue(ColorValue value)
        {
            return new BorderColorValue(value.ToString());
        }

        public static implicit operator BorderColorValue(int value)
        {
            return new BorderColorValue("#" + value.ToString("X"));
        }

        public static implicit operator BorderColorValue((ColorValue hValue, ColorValue vValue) value)
        {
            return new BorderColorValue(value.hValue.ToString() + " " + value.vValue.ToString());
        }

        public static implicit operator BorderColorValue((ColorValue topValue, ColorValue vValue, ColorValue bottomValue) value)
        {
            return new BorderColorValue(value.topValue.ToString() + " " + value.vValue.ToString() + " " + value.bottomValue.ToString());
        }

        public static implicit operator BorderColorValue((ColorValue topValue, ColorValue rightValue, ColorValue bottomValue, ColorValue leftValue) value)
        {
            return new BorderColorValue(value.topValue.ToString() + " " + value.rightValue.ToString() + " " + value.bottomValue.ToString() + " " + value.leftValue.ToString());
        }
    }
}
