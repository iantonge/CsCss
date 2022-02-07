using CsCss.Values.Numeric.Angle;
using CsCss.Values.Numeric.Calc;
using CsCss.Values.Numeric.LengthPercentage;
using CsCss.Values.Numeric.Length;
using CsCss.Values.Numeric.Percentage;
using CsCss.Values.Numeric.Time;
using CsCss.Values.Numeric.AnglePercentage;
using CsCss.Values.Numeric.TimePercentage;

namespace CsCss
{
    public static partial class Statics
    {
        public static AngleValue Calc(CalcValue<AngleValue> calcValue)
        {
            return new AngleValue("calc(" + calcValue.ToString() + ")");
        }

        public static LengthValue Calc(CalcValue<LengthValue> calcValue)
        {
            return new LengthValue("calc(" + calcValue.ToString() + ")");
        }

        public static PercentageValue Calc(CalcValue<PercentageValue> calcValue)
        {
            return new PercentageValue("calc(" + calcValue.ToString() + ")");
        }

        public static TimeValue Calc(CalcValue<TimeValue> calcValue)
        {
            return new TimeValue("calc(" + calcValue.ToString() + ")");
        }

        public static LengthPercentageValue Calc(CalcValue<LengthPercentageValue> calcValue)
        {
            return new LengthPercentageValue("calc(" + calcValue.ToString() + ")");
        }

        public static AnglePercentageValue Calc(CalcValue<AnglePercentageValue> calcValue)
        {
            return new AnglePercentageValue("calc(" + calcValue.ToString() + ")");
        }

        public static TimePercentageValue Calc(CalcValue<TimePercentageValue> calcValue)
        {
            return new TimePercentageValue("calc(" + calcValue.ToString() + ")");
        }
    }
}
