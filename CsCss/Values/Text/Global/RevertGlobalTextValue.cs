namespace CsCss.Values.Text.Global
{
    public sealed class RevertGlobalTextValue : GlobalTextValue
    {
        private RevertGlobalTextValue() : base("revert") {}

        internal static readonly RevertGlobalTextValue Revert = new RevertGlobalTextValue();
    }
}
