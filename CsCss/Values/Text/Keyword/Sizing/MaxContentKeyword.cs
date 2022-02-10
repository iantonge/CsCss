namespace CsCss.Values.Text.Keyword.Sizing
{
    public sealed class MaxContentKeyword : Keyword
    {
        private MaxContentKeyword() : base("max-content") { }

        internal static readonly MaxContentKeyword MaxContent = new MaxContentKeyword();
    }
}
