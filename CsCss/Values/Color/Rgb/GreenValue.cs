using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Rgb
{
    public sealed class GreenValue
    {
        private readonly string value;

        private GreenValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator GreenValue(int value)
        {
            return new GreenValue(value.ToString());
        }

        public static implicit operator GreenValue(double value)
        {
            return new GreenValue(value.ToString());
        }

        public static implicit operator GreenValue(PercentageValue value)
        {
            return new GreenValue(value.ToString());
        }
    }
}
