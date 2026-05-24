using CsCss.Values.Angle;
using CsCss.Values.AnglePercentage;
using CsCss.Values.Calc;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;
using CsCss.Values.Time;
using CsCss.Values.TimePercentage;

namespace CsCss;

public static partial class Functions
{
    public static AngleValue Calc(CalcValue<AngleValue> calcValue) => new AngleValue("calc(" + calcValue.ToString() + ")");

    public static LengthValue Calc(CalcValue<LengthValue> calcValue) => new LengthValue("calc(" + calcValue.ToString() + ")");

    public static PercentageValue Calc(CalcValue<PercentageValue> calcValue) => new PercentageValue("calc(" + calcValue.ToString() + ")");

    public static TimeValue Calc(CalcValue<TimeValue> calcValue) => new TimeValue("calc(" + calcValue.ToString() + ")");

    public static LengthPercentageValue Calc(CalcValue<LengthPercentageValue> calcValue) => new LengthPercentageValue("calc(" + calcValue.ToString() + ")");

    public static AnglePercentageValue Calc(CalcValue<AnglePercentageValue> calcValue) => new AnglePercentageValue("calc(" + calcValue.ToString() + ")");

    public static TimePercentageValue Calc(CalcValue<TimePercentageValue> calcValue) => new TimePercentageValue("calc(" + calcValue.ToString() + ")");
}
