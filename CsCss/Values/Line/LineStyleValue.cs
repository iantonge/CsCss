using CsCss.Values.General;

namespace CsCss.Values.Line;

public sealed class LineStyleValue: Value
{
    private LineStyleValue(string v) : base(v) { }

    internal static readonly LineStyleValue Hidden = new("hidden");
    internal static readonly LineStyleValue Dotted = new("dotted");
    internal static readonly LineStyleValue Dashed = new("dashed");
    internal static readonly LineStyleValue Solid = new("solid");
    internal static readonly LineStyleValue Double = new("double");
    internal static readonly LineStyleValue Groove = new("groove");
    internal static readonly LineStyleValue Ridge = new("ridge");
    internal static readonly LineStyleValue Inset = new("inset");
    internal static readonly LineStyleValue Outset = new("outset");

    public static implicit operator LineStyleValue(NoneKeyword value)
    {
        return new LineStyleValue(value.ToString());
    }
}
