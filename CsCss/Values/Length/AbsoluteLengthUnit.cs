namespace CsCss.Values.Length;

public class AbsoluteLengthUnit : LengthUnit
{
    private AbsoluteLengthUnit(string u) : base(u)
    {

    }

    internal static readonly AbsoluteLengthUnit Cm = new("cm");
    internal static readonly AbsoluteLengthUnit Mm = new("mm");
    internal static readonly AbsoluteLengthUnit Q = new("Q");
    internal static readonly AbsoluteLengthUnit In = new("in");
    internal static readonly AbsoluteLengthUnit Pc = new("pc");
    internal static readonly AbsoluteLengthUnit Pt = new("pt");
    internal static readonly AbsoluteLengthUnit Px = new("px");
}
