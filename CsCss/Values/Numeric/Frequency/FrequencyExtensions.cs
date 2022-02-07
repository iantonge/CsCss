using CsCss.Values.Numeric.Frequency;

namespace CsCss
{
    public static class FrequencyExtensions
    {
        public static FrequencyValue Hz(this double input)
        {
            return new FrequencyValue(input, FrequencyUnit.Hz);
        }

        public static FrequencyValue Hz(this int input)
        {
            return new FrequencyValue(input, FrequencyUnit.Hz);
        }

        public static FrequencyValue KHz(this double input)
        {
            return new FrequencyValue(input, FrequencyUnit.KHz);
        }

        public static FrequencyValue KHz(this int input)
        {
            return new FrequencyValue(input, FrequencyUnit.KHz);
        }
    }
}
