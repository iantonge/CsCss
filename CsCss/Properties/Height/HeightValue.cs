using CsCss.Values;
using CsCss.Values.Numeric.LengthPercentage;
using CsCss.Values.Text.Global;
using CsCss.Values.Text.Keyword;

namespace CsCss.Properties.Height
{
    public class HeightValue : Value
    {
        private HeightValue(string value) : base(value) { }

        public static implicit operator HeightValue(GlobalKeyword value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(int value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(double value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(LengthPercentageValue value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(AutoKeyword value)
        {
            return new HeightValue(value.ToString());
        }
    }
}
