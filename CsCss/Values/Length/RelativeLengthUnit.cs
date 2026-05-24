namespace CsCss.Values.Length;

public class RelativeLengthUnit : LengthUnit
{
    private RelativeLengthUnit(string u) : base(u)
    {

    }

    internal static readonly RelativeLengthUnit Em = new("em");
    internal static readonly RelativeLengthUnit Ex = new("ex");
    internal static readonly RelativeLengthUnit Ch = new("ch");
    internal static readonly RelativeLengthUnit Rem = new("rem");
    internal static readonly RelativeLengthUnit Lh = new("lh");
    internal static readonly RelativeLengthUnit Vw = new("vw");
    internal static readonly RelativeLengthUnit Vh = new("vh");
    internal static readonly RelativeLengthUnit VMin = new("vmin");
    internal static readonly RelativeLengthUnit VMax = new("vmax");
}
