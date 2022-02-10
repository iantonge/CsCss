namespace CsCss.Values.Global
{
    public sealed class GlobalKeyword : Value
    {
        private GlobalKeyword(string v) : base(v) { }

        internal static readonly GlobalKeyword Inherit = new GlobalKeyword("inherit");
        internal static readonly GlobalKeyword Initial = new GlobalKeyword("initial");
        internal static readonly GlobalKeyword Revert = new GlobalKeyword("revert");
        internal static readonly GlobalKeyword Unset = new GlobalKeyword("unset");
    }
}
