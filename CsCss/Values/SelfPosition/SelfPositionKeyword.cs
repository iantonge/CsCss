namespace CsCss.Values.SelfPosition;

public sealed class SelfPositionKeyword : Value
{
    private SelfPositionKeyword(string v) : base(v) { }

    internal static readonly SelfPositionKeyword SelfStart = new("self-start");
    internal static readonly SelfPositionKeyword SelfEnd = new("self-end");
}
