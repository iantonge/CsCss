using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Function
{
    public sealed class RgbComponent
    {
        private readonly string value;

        private RgbComponent(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator RgbComponent(int value)
        {
            return new RgbComponent(value.ToString());
        }

        public static implicit operator RgbComponent(double value)
        {
            return new RgbComponent(value.ToString());
        }

        public static implicit operator RgbComponent(PercentageValue value)
        {
            return new RgbComponent(value.ToString());
        }
    }
}
