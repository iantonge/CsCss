namespace CsCss.Values.Text.Keyword.Sizing
{
    public sealed class MinContentKeyword : Keyword
    {
        private MinContentKeyword() : base("min-content") { }

        internal static readonly MinContentKeyword MinContent = new MinContentKeyword();
    }
}
