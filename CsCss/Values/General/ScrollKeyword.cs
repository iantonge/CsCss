namespace CsCss.Values.General
{
    public sealed class ScrollKeyword : Keyword
    {
        private ScrollKeyword() : base("scroll") {}

        internal static readonly ScrollKeyword Scroll = new ScrollKeyword();
    }
}
