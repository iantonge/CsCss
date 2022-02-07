using CsCss.Values.Numeric.LengthPercentage.Percentage;

namespace CsCss.Values.Color.Hsl
{
    public sealed class SaturationValue
    {
        private readonly string value;

        private SaturationValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator SaturationValue(PercentageValue value)
        {
            return new SaturationValue(value.ToString());
        }
    }
}
