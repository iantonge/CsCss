using CsCss.Values.Angle;
using CsCss.Values.AnglePercentage;
using CsCss.Values.Calc;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Time;
using CsCss.Values.TimePercentage;

namespace CsCss.Values.Percentage;

public sealed class PercentageValue : Value
{
    internal double? Number { get; }

    internal PercentageValue(string v) : base(v) { }

    internal PercentageValue(int number, PercentageUnit unit) : base($"{number}{unit}")
    {
        Number = number;
    }

    internal PercentageValue(double number, PercentageUnit unit) : base($"{number}{unit}")
    {
        Number = number;
    }

    public static CalcSum<PercentageValue> operator +(PercentageValue a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<PercentageValue> operator +(PercentageValue a, CalcSum<PercentageValue> b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator +(PercentageValue a, CalcSum<LengthValue> b)
        => new($"{a} + {b}");

    public static CalcSum<AnglePercentageValue> operator +(PercentageValue a, CalcSum<AngleValue> b)
        => new($"{a} + {b}");

    public static CalcSum<TimePercentageValue> operator +(PercentageValue a, CalcSum<TimeValue> b)
        => new($"{a} + {b}");

    public static CalcSum<PercentageValue> operator +(PercentageValue a, CalcProduct<PercentageValue> b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator +(PercentageValue a, CalcProduct<LengthValue> b)
        => new($"{a} + {b}");

    public static CalcSum<AnglePercentageValue> operator +(PercentageValue a, CalcProduct<AngleValue> b)
        => new($"{a} + {b}");

    public static CalcSum<TimePercentageValue> operator +(PercentageValue a, CalcProduct<TimeValue> b)
        => new($"{a} + {b}");

    public static CalcSum<PercentageValue> operator +(CalcSum<PercentageValue> a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator +(CalcSum<LengthValue> a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<AnglePercentageValue> operator +(CalcSum<AngleValue> a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<TimePercentageValue> operator +(CalcSum<TimeValue> a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<PercentageValue> operator +(CalcProduct<PercentageValue> a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator +(CalcProduct<LengthValue> a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<AnglePercentageValue> operator +(CalcProduct<AngleValue> a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<TimePercentageValue> operator +(CalcProduct<TimeValue> a, PercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<PercentageValue> operator -(PercentageValue a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<PercentageValue> operator -(PercentageValue a, CalcSum<PercentageValue> b)
        => new($"{a} - {b}");

    public static CalcSum<LengthPercentageValue> operator -(PercentageValue a, CalcSum<LengthValue> b)
        => new($"{a} - {b}");

    public static CalcSum<AnglePercentageValue> operator -(PercentageValue a, CalcSum<AngleValue> b)
        => new($"{a} - {b}");

    public static CalcSum<TimePercentageValue> operator -(PercentageValue a, CalcSum<TimeValue> b)
        => new($"{a} - {b}");

    public static CalcSum<PercentageValue> operator -(PercentageValue a, CalcProduct<PercentageValue> b)
        => new($"{a} - {b}");

    public static CalcSum<LengthPercentageValue> operator -(PercentageValue a, CalcProduct<LengthValue> b)
        => new($"{a} - {b}");

    public static CalcSum<AnglePercentageValue> operator -(PercentageValue a, CalcProduct<AngleValue> b)
        => new($"{a} - {b}");

    public static CalcSum<TimePercentageValue> operator -(PercentageValue a, CalcProduct<TimeValue> b)
        => new($"{a} - {b}");

    public static CalcSum<PercentageValue> operator -(CalcSum<PercentageValue> a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<LengthPercentageValue> operator -(CalcSum<LengthValue> a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<AnglePercentageValue> operator -(CalcSum<AngleValue> a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<TimePercentageValue> operator -(CalcSum<TimeValue> a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<PercentageValue> operator -(CalcProduct<PercentageValue> a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<LengthPercentageValue> operator -(CalcProduct<LengthValue> a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<AnglePercentageValue> operator -(CalcProduct<AngleValue> a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<TimePercentageValue> operator -(CalcProduct<TimeValue> a, PercentageValue b)
        => new($"{a} - {b}");

    public static CalcProduct<PercentageValue> operator *(PercentageValue a, int b)
        => new($"{a} * {b}");

    public static CalcProduct<PercentageValue> operator *(PercentageValue a, double b)
        => new($"{a} * {b}");

    public static CalcProduct<PercentageValue> operator *(int a, PercentageValue b)
        => new($"{a} * {b}");

    public static CalcProduct<PercentageValue> operator *(double a, PercentageValue b)
        => new($"{a} * {b}");

    public static CalcProduct<PercentageValue> operator /(PercentageValue a, int b)
        => new($"{a} / {b}");

    public static CalcProduct<PercentageValue> operator /(PercentageValue a, double b)
        => new($"{a} / {b}");
}
