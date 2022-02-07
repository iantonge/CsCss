namespace CsCss.Values.Numeric.Length
{
    public class AbsoluteLengthUnit : LengthUnit
    {
        private AbsoluteLengthUnit(string u) : base(u)
        {

        }

        internal static readonly AbsoluteLengthUnit Cm = new AbsoluteLengthUnit("cm");
        internal static readonly AbsoluteLengthUnit Mm = new AbsoluteLengthUnit("mm");
        internal static readonly AbsoluteLengthUnit Q = new AbsoluteLengthUnit("Q");
        internal static readonly AbsoluteLengthUnit In = new AbsoluteLengthUnit("in");
        internal static readonly AbsoluteLengthUnit Pc = new AbsoluteLengthUnit("pc");
        internal static readonly AbsoluteLengthUnit Pt = new AbsoluteLengthUnit("pt");
        internal static readonly AbsoluteLengthUnit Px = new AbsoluteLengthUnit("px");
    }
}
