namespace CsCss.Values.General
{
    public sealed class FixedKeyword : Value
    {
        private FixedKeyword() : base("fixed") {}

        internal static readonly FixedKeyword Fixed = new FixedKeyword();
    }
}
