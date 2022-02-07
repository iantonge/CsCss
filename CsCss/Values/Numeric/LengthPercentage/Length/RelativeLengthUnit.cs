namespace CsCss.Values.Numeric.LengthPercentage.Length
{
    public class RelativeLengthUnit : LengthUnit
    {
        private RelativeLengthUnit(string u) : base(u)
        {

        }

        internal static readonly RelativeLengthUnit Em = new RelativeLengthUnit("em");
        internal static readonly RelativeLengthUnit Ex = new RelativeLengthUnit("ex");
        internal static readonly RelativeLengthUnit Ch = new RelativeLengthUnit("ch");
        internal static readonly RelativeLengthUnit Rem = new RelativeLengthUnit("rem");
        internal static readonly RelativeLengthUnit Lh = new RelativeLengthUnit("lh");
        internal static readonly RelativeLengthUnit Vw = new RelativeLengthUnit("vw");
        internal static readonly RelativeLengthUnit Vh = new RelativeLengthUnit("vh");
        internal static readonly RelativeLengthUnit VMin = new RelativeLengthUnit("vmin");
        internal static readonly RelativeLengthUnit VMax = new RelativeLengthUnit("vmax");
    }
}
