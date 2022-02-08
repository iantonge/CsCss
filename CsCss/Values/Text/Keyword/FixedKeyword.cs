namespace CsCss.Values.Text.Keyword
{
    public sealed class FixedKeyword : Keyword
    {
        private FixedKeyword() : base("fixed") {}

        internal static readonly FixedKeyword Fixed = new FixedKeyword();
    }
}
