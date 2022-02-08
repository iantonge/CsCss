namespace CsCss.Values.Text.Keyword
{
    public sealed class LocalKeyword : Keyword
    {
        private LocalKeyword() : base("local") {}

        internal static readonly LocalKeyword Local = new LocalKeyword();
    }
}
