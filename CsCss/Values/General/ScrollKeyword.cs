namespace CsCss.Values.General
{
    public sealed class ScrollKeyword : Value
    {
        private ScrollKeyword() : base("scroll") {}

        internal static readonly ScrollKeyword Scroll = new ScrollKeyword();
    }
}
