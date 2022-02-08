namespace CsCss.Values.Text.Global
{
    public sealed class InitialKeyword : GlobalKeyword
    {
        private InitialKeyword() : base("initial") {}

        internal static readonly InitialKeyword Initial = new InitialKeyword();
    }
}
