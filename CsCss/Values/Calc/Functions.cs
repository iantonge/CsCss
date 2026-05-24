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
    public static AngleValue Calc(CalcValue<AngleValue> calcValue) => new($"calc({calcValue})");

    public static LengthValue Calc(CalcValue<LengthValue> calcValue) => new($"calc({calcValue})");

    public static PercentageValue Calc(CalcValue<PercentageValue> calcValue) => new($"calc({calcValue})");

    public static TimeValue Calc(CalcValue<TimeValue> calcValue) => new($"calc({calcValue})");

    public static LengthPercentageValue Calc(CalcValue<LengthPercentageValue> calcValue) => new($"calc({calcValue})");

    public static AnglePercentageValue Calc(CalcValue<AnglePercentageValue> calcValue) => new($"calc({calcValue})");

    public static TimePercentageValue Calc(CalcValue<TimePercentageValue> calcValue) => new($"calc({calcValue})");
}
