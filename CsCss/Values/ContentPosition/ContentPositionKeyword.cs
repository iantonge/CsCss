namespace CsCss.Values.ContentPosition;

public sealed class ContentPositionKeyword : Value
{
    private ContentPositionKeyword(string v) : base(v) { }

    internal static readonly ContentPositionKeyword Start = new("start");
    internal static readonly ContentPositionKeyword End = new("end");
    internal static readonly ContentPositionKeyword FlexStart = new("flex-start");
    internal static readonly ContentPositionKeyword FlexEnd = new("flex-end");
}
