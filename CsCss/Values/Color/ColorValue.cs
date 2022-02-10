using CsCss.Values.Global;

namespace CsCss.Values.Color
{
    public class ColorValue : Value
    {
        protected ColorValue(string v) : base(v) { }

        public static implicit operator ColorValue(int value)
        {
            return new ColorValue("#" + value.ToString("X"));
        }

        public static implicit operator ColorValue(GlobalKeyword value)
        {
            return new ColorValue(value.ToString());
        }
    }
}
