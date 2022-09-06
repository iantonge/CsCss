namespace CsCss.Values.ContentPosition
{
    public sealed class ContentPositionKeyword : Value
    {
        private ContentPositionKeyword(string v) : base(v) { }

        internal static readonly ContentPositionKeyword Start = new ContentPositionKeyword("start");
        internal static readonly ContentPositionKeyword End = new ContentPositionKeyword("end");
        internal static readonly ContentPositionKeyword FlexStart = new ContentPositionKeyword("flex-start");
        internal static readonly ContentPositionKeyword FlexEnd = new ContentPositionKeyword("flex-end");
    }
}
