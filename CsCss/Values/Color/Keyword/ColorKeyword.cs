using CsCss.Values.Global;

namespace CsCss.Values.Color.Keyword
{
    public sealed class ColorKeyword : ColorValue
    {
        private ColorKeyword(string v) : base(v) { }

        internal static readonly ColorKeyword Transparent = new ColorKeyword("transparent");
        internal static readonly ColorKeyword CurrentColor = new ColorKeyword("currentcolor");
    }
}
