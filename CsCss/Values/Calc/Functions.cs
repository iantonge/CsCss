using CsCss.Values.Angle;
using CsCss.Values.Calc;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Length;
using CsCss.Values.Percentage;
using CsCss.Values.Time;
using CsCss.Values.AnglePercentage;
using CsCss.Values.TimePercentage;

namespace CsCss
{
    public static partial class Functions
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
