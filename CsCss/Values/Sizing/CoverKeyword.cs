namespace CsCss.Values.Sizing
{
    public sealed class CoverKeyword : Value
    {
        private CoverKeyword() : base("cover") { }

        internal static readonly CoverKeyword Cover = new CoverKeyword();
    }
}
