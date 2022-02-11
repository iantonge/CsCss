namespace CsCss.Values.Resolution
{
    public class ResolutionUnit : Unit
    {
        private ResolutionUnit(string u) : base(u) { }

        internal static readonly ResolutionUnit Dpi = new ResolutionUnit("dpi");
        internal static readonly ResolutionUnit Dpcm = new ResolutionUnit("dpcm");
        internal static readonly ResolutionUnit Dppx = new ResolutionUnit("dppx");
        internal static readonly ResolutionUnit X = new ResolutionUnit("x");
    }
}
