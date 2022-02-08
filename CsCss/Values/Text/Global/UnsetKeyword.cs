namespace CsCss.Values.Text.Global
{
    public sealed class UnsetKeyword : GlobalKeyword
    {
        private UnsetKeyword() : base("unset") {}

        internal static readonly UnsetKeyword Unset = new UnsetKeyword();
    }
}
