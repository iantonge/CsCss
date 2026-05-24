namespace CsCss.Values.Resolution;

public class ResolutionUnit : Unit
{
    private ResolutionUnit(string u) : base(u) { }

    internal static readonly ResolutionUnit Dpi = new("dpi");
    internal static readonly ResolutionUnit Dpcm = new("dpcm");
    internal static readonly ResolutionUnit Dppx = new("dppx");
    internal static readonly ResolutionUnit X = new("x");
}
