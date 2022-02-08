namespace CsCss.Values.Text.Global
{
    public sealed class RevertKeyword : GlobalKeyword
    {
        private RevertKeyword() : base("revert") {}

        internal static readonly RevertKeyword Revert = new RevertKeyword();
    }
}
