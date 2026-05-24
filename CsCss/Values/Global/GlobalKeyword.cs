namespace CsCss.Values.Global;

public sealed class GlobalKeyword : Value
{
    private GlobalKeyword(string v) : base(v) { }

    internal static readonly GlobalKeyword Inherit = new("inherit");
    internal static readonly GlobalKeyword Initial = new("initial");
    internal static readonly GlobalKeyword Revert = new("revert");
    internal static readonly GlobalKeyword Unset = new("unset");
}
