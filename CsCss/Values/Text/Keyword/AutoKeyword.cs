namespace CsCss.Values.Text.Keyword
{
    public sealed class AutoKeyword : Keyword
    {
        private AutoKeyword() : base("auto") { }

        internal static readonly AutoKeyword Auto = new AutoKeyword();
    }
}
