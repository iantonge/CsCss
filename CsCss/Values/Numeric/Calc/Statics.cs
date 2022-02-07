using CsCss.Values.Numeric.Angle;
using CsCss.Values.Numeric.Calc;
using CsCss.Values.Numeric.Frequency;
using CsCss.Values.Numeric.LengthPercentage;
using CsCss.Values.Numeric.LengthPercentage.Length;
using CsCss.Values.Numeric.LengthPercentage.Percentage;
using CsCss.Values.Numeric.Time;

namespace CsCss
{
    public static partial class Statics
    {
        public static AngleValue Calc(CalcValue<AngleValue> calcValue)
        {
            return new AngleValue("calc(" + calcValue.ToString() + ")");
        }

        public static FrequencyValue Calc(CalcValue<FrequencyValue> calcValue)
        {
            return new FrequencyValue("calc(" + calcValue.ToString() + ")");
        }

        public static LengthValue Calc(CalcValue<LengthValue> calcValue)
        {
            return new LengthValue("calc(" + calcValue.ToString() + ")");
        }

        public static PercentageValue Calc(CalcValue<PercentageValue> calcValue)
        {
            return new PercentageValue("calc(" + calcValue.ToString() + ")");
        }

        public static LengthPercentageValue Calc(CalcValue<LengthPercentageValue> calcValue)
        {
            return new LengthPercentageValue("calc(" + calcValue.ToString() + ")");
        }

        public static TimeValue Calc(CalcValue<TimeValue> calcValue)
        {
            return new TimeValue("calc(" + calcValue.ToString() + ")");
        }
    }
}
