using CsCss.Values.Length;

namespace CsCss.Values.Line;

public sealed class LineWidthValue : Value
{
    private LineWidthValue(string v) : base(v) { }

    internal static readonly LineWidthValue Thin = new("thin");
    internal static readonly LineWidthValue Medium = new("medium");
    internal static readonly LineWidthValue Thick = new("thick");

    public static implicit operator LineWidthValue(LengthValue value)
    {
        return new LineWidthValue(value.ToString());
    }
}
