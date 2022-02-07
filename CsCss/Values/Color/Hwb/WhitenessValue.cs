using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Hwb
{
    public sealed class WhitenessValue
    {
        private readonly string value;

        private WhitenessValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator WhitenessValue(PercentageValue value)
        {
            return new WhitenessValue(value.ToString());
        }
    }
}
