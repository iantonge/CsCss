using CsCss.Values;
using CsCss.Values.General;
using CsCss.Values.Global;

namespace CsCss.Properties.AccentColor
{
    public class AccentColorValue : Value
    {
        public AccentColorValue(string v) : base(v) { }

        public static implicit operator AccentColorValue(AutoKeyword value)
        {
            return new AccentColorValue(value.ToString());
        }

        public static implicit operator AccentColorValue(GlobalKeyword value)
        {
            return new AccentColorValue(value.ToString());
        }

        public static implicit operator AccentColorValue(Values.Color.ColorValue value)
        {
            return new AccentColorValue(value.ToString());
        }

        public static implicit operator AccentColorValue(int value)
        {
            return new AccentColorValue("#" + value.ToString("X"));
        }
    }
}
