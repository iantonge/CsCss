using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Hwb
{
    public sealed class AlphaValue
    {
        private readonly string value;

        private AlphaValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator AlphaValue(int value)
        {
            return new AlphaValue(value.ToString());
        }

        public static implicit operator AlphaValue(double value)
        {
            return new AlphaValue(value.ToString());
        }

        public static implicit operator AlphaValue(PercentageValue value)
        {
            return new AlphaValue(value.ToString());
        }
    }
}
