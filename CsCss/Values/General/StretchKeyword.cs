namespace CsCss.Values.General
{
    public sealed class StretchKeyword : Value
    {
        private StretchKeyword() : base("stretch") { }

        internal static readonly StretchKeyword Stretch = new StretchKeyword();
    }
}
