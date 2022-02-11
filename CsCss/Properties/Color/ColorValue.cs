using CsCss.Values;
using CsCss.Values.Global;

namespace CsCss.Properties.Color
{
    public class ColorValue : Value
    {
        public ColorValue(string v) : base(v) { }

        public static implicit operator ColorValue(GlobalKeyword value)
        {
            return new ColorValue(value.ToString());
        }

        public static implicit operator ColorValue(Values.Color.ColorValue value)
        {
            return new ColorValue(value.ToString());
        }

        public static implicit operator ColorValue(int value)
        {
            return new ColorValue("#" + value.ToString("X"));
        }
    }
}
