namespace CsCss.Values.Color.Keyword
{
    public sealed class CurrentColorKeyword : ColorKeyword
    {
        private CurrentColorKeyword() : base("currentcolor") { }

        internal static readonly CurrentColorKeyword CurrentColor = new CurrentColorKeyword();
    }
}
