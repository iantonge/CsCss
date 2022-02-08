namespace CsCss.Values.Text.Global
{
    public sealed class InheritKeyword : GlobalKeyword
    {
        private InheritKeyword() : base("inherit") {}

        internal static readonly InheritKeyword Inherit = new InheritKeyword();
    }
}
