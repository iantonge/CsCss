using CsCss.Values.Calc;
using CsCss.Values.Length;
using CsCss.Values.Percentage;

namespace CsCss.Values.LengthPercentage;

public class LengthPercentageValue : Value
{
    internal LengthPercentageValue(string v) : base(v) { }

    public static implicit operator LengthPercentageValue(LengthValue value)
    {
        return new(value.ToString());
    }

    public static implicit operator LengthPercentageValue(PercentageValue value)
    {
        return new(value.ToString());
    }

    public static CalcSum<LengthPercentageValue> operator +(LengthPercentageValue a, LengthPercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator +(LengthPercentageValue a, CalcSum<LengthPercentageValue> b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator +(LengthPercentageValue a, CalcProduct<LengthPercentageValue> b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator +(CalcSum<LengthPercentageValue> a, LengthPercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator +(CalcProduct<LengthPercentageValue> a, LengthPercentageValue b)
        => new($"{a} + {b}");

    public static CalcSum<LengthPercentageValue> operator -(LengthPercentageValue a, LengthPercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<LengthPercentageValue> operator -(LengthPercentageValue a, CalcSum<LengthPercentageValue> b)
        => new($"{a} - {b}");

    public static CalcSum<LengthPercentageValue> operator -(LengthPercentageValue a, CalcProduct<LengthPercentageValue> b)
        => new($"{a} - {b}");

    public static CalcSum<LengthPercentageValue> operator -(CalcSum<LengthPercentageValue> a, LengthPercentageValue b)
        => new($"{a} - {b}");

    public static CalcSum<LengthPercentageValue> operator -(CalcProduct<LengthPercentageValue> a, LengthPercentageValue b)
        => new($"{a} - {b}");

    public static CalcProduct<LengthPercentageValue> operator *(LengthPercentageValue a, int b)
        => new($"{a} * {b}");

    public static CalcProduct<LengthPercentageValue> operator *(LengthPercentageValue a, double b)
        => new($"{a} * {b}");

    public static CalcProduct<LengthPercentageValue> operator *(int a, LengthPercentageValue b)
        => new($"{a} * {b}");

    public static CalcProduct<LengthPercentageValue> operator *(double a, LengthPercentageValue b)
        => new($"{a} * {b}");

    public static CalcProduct<LengthPercentageValue> operator /(LengthPercentageValue a, int b)
        => new($"{a} / {b}");

    public static CalcProduct<LengthPercentageValue> operator /(LengthPercentageValue a, double b)
        => new($"{a} / {b}");
}
