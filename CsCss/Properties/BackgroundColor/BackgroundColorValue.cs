using CsCss.Values;
using CsCss.Values.Color;
using CsCss.Values.Global;

namespace CsCss.Properties.BackgroundColor
{
    public class BackgroundColorValue : Value
    {
        public BackgroundColorValue(string v) : base(v) { }

        public static implicit operator BackgroundColorValue(GlobalKeyword value)
        {
            return new BackgroundColorValue(value.ToString());
        }

        public static implicit operator BackgroundColorValue(ColorValue value)
        {
            return new BackgroundColorValue(value.ToString());
        }

        public static implicit operator BackgroundColorValue(int value)
        {
            return new BackgroundColorValue("#" + value.ToString("X"));
        }
    }
}
