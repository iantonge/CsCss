using CsCss.Values.Angle;

namespace CsCss;

public static class AngleExtensions
{
    public static AngleValue Deg(this double input) => new(input, AngleUnit.Deg);

    public static AngleValue Deg(this int input) => new(input, AngleUnit.Deg);

    public static AngleValue Rad(this double input) => new(input, AngleUnit.Rad);

    public static AngleValue Rad(this int input) => new(input, AngleUnit.Rad);

    public static AngleValue Grad(this double input) => new(input, AngleUnit.Grad);

    public static AngleValue Grad(this int input) => new(input, AngleUnit.Grad);

    public static AngleValue Turn(this double input) => new(input, AngleUnit.Turn);

    public static AngleValue Turn(this int input) => new(input, AngleUnit.Turn);
}
