namespace CsCss.Values.General
{
    public sealed class DefaultKeyword : Value
    {
        private DefaultKeyword() : base("default") { }

        internal static readonly DefaultKeyword Default = new DefaultKeyword();
    }
}
