namespace CsCss.Values.General
{
    public sealed class NoneKeyword : Value
    {
        private NoneKeyword() : base("none") { }

        internal static readonly NoneKeyword None = new NoneKeyword();
    }
}
