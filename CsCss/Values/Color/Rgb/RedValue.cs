using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Rgb
{
    public sealed class RedValue
    {
        private readonly string value;

        private RedValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator RedValue(int value)
        {
            return new RedValue(value.ToString());
        }

        public static implicit operator RedValue(double value)
        {
            return new RedValue(value.ToString());
        }

        public static implicit operator RedValue(PercentageValue value)
        {
            return new RedValue(value.ToString());
        }
    }
}
