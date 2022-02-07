using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Hwb
{
    public sealed class BlacknessValue
    {
        private readonly string value;

        private BlacknessValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator BlacknessValue(PercentageValue value)
        {
            return new BlacknessValue(value.ToString());
        }
    }
}
