namespace CsCss.Values.Calc;

public sealed class CalcSum<T> : CalcValue<T> where T : Value
{
    public CalcSum(string v) : base(v) { }

    public static CalcSum<T> operator +(CalcSum<T> a, CalcProduct<T> b)
        => new($"{a} + {b}");

    public static CalcSum<T> operator +(CalcSum<T> a, CalcSum<T> b)
        => new($"{a} + {b}");

    public static CalcSum<T> operator -(CalcSum<T> a, CalcProduct<T> b)
        => new($"{a} - {b}");

    public static CalcSum<T> operator -(CalcSum<T> a, CalcSum<T> b)
        => new($"{a} - {b}");

    public static CalcProduct<T> operator *(int a, CalcSum<T> b)
        => new(a.ToString() + " * (" + b.ToString() + ")");

    public static CalcProduct<T> operator *(double a, CalcSum<T> b)
        => new(a.ToString() + " * (" + b.ToString() + ")");

    public static CalcProduct<T> operator *(CalcSum<T> a, int b)
        => new("(" + a.ToString() + ") * " + b.ToString());

    public static CalcProduct<T> operator *(CalcSum<T> a, double b)
        => new("(" + a.ToString() + ") * " + b.ToString());

    public static CalcProduct<T> operator /(CalcSum<T> a, int b)
        => new("(" + a.ToString() + ") / " + b.ToString());

    public static CalcProduct<T> operator /(CalcSum<T> a, double b)
        => new("(" + a.ToString() + ") / " + b.ToString());
}
