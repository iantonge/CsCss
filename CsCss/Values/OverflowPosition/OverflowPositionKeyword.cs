namespace CsCss.Values.OverflowPosition
{
    public sealed class OverflowPositionKeyword : Value
    {
        private OverflowPositionKeyword(string v) : base(v) { }

        internal static readonly OverflowPositionKeyword Safe = new OverflowPositionKeyword("safe");
        internal static readonly OverflowPositionKeyword Unsafe = new OverflowPositionKeyword("unsafe");
    }
}
