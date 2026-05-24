namespace CsCss.Values.Box;

public sealed class BoxKeyword : Value
{
    private BoxKeyword(string v) : base(v) { }

    internal static readonly BoxKeyword BorderBox = new("border-box");
    internal static readonly BoxKeyword PaddingBox = new("padding-box");
    internal static readonly BoxKeyword ContentBox = new("content-box");
}
