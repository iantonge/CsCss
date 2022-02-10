using CsCss.Values.General;

namespace CsCss.Values.Sizing
{
    public sealed class MinContentKeyword : Keyword
    {
        private MinContentKeyword() : base("min-content") { }

        internal static readonly MinContentKeyword MinContent = new MinContentKeyword();
    }
}
