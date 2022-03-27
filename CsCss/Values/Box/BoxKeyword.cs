namespace CsCss.Values.Box
{
    public sealed class BoxKeyword : Value
    {
        private BoxKeyword(string v) : base(v) { }

        internal static readonly BoxKeyword BorderBox = new BoxKeyword("border-box");
        internal static readonly BoxKeyword PaddingBox = new BoxKeyword("padding-box");
        internal static readonly BoxKeyword ContentBox = new BoxKeyword("content-box");
    }
}
