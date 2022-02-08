namespace CsCss.Values.Color.Keyword
{
    public sealed class TransparentKeyword : ColorKeyword
    {
        private TransparentKeyword() : base("transparent") { }

        internal static readonly TransparentKeyword Transparent = new TransparentKeyword();
    }
}