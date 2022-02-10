namespace CsCss.Values.Sizing
{
    public sealed class MinContentKeyword : Value
    {
        private MinContentKeyword() : base("min-content") { }

        internal static readonly MinContentKeyword MinContent = new MinContentKeyword();
    }
}
