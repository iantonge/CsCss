namespace CsCss.Values.Text.Keyword.Sizing
{
    public sealed class FitContentKeyword : Keyword
    {
        private FitContentKeyword() : base("fit-content") { }

        internal static readonly FitContentKeyword FitContent = new FitContentKeyword();
    }
}
