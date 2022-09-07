namespace CsCss.Values.SelfPosition
{
    public sealed class SelfPositionKeyword : Value
    {
        private SelfPositionKeyword(string v) : base(v) { }

        internal static readonly SelfPositionKeyword SelfStart = new SelfPositionKeyword("self-start");
        internal static readonly SelfPositionKeyword SelfEnd = new SelfPositionKeyword("self-end");
    }
}
