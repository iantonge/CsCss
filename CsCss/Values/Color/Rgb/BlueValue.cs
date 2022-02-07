using CsCss.Values.Numeric.LengthPercentage.Percentage;

namespace CsCss.Values.Color.Rgb
{
    public sealed class BlueValue
    {
        private readonly string value;

        private BlueValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator BlueValue(int value)
        {
            return new BlueValue(value.ToString());
        }

        public static implicit operator BlueValue(double value)
        {
            return new BlueValue(value.ToString());
        }

        public static implicit operator BlueValue(PercentageValue value)
        {
            return new BlueValue(value.ToString());
        }
    }
}
