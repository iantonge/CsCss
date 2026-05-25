using CsCss.Values;

namespace CsCss.AtRules.FontFace;

public sealed class FontDisplayValue : Value
{
    private FontDisplayValue(string value) : base(value) { }

    internal static readonly FontDisplayValue Auto = new("auto");
    internal static readonly FontDisplayValue Block = new("block");
    internal static readonly FontDisplayValue Swap = new("swap");
    internal static readonly FontDisplayValue Fallback = new("fallback");
    internal static readonly FontDisplayValue Optional = new("optional");
}
