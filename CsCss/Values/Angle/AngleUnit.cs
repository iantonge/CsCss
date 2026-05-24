namespace CsCss.Values.Angle;

public class AngleUnit : Unit
{
    private AngleUnit(string u) : base(u)
    {
    }

    internal static readonly AngleUnit Deg = new("deg");
    internal static readonly AngleUnit Rad = new("rad");
    internal static readonly AngleUnit Grad = new("grad");
    internal static readonly AngleUnit Turn = new("turn");
}
