namespace CsCss.Values.General
{
    public sealed class LocalKeyword : Value
    {
        private LocalKeyword() : base("local") {}

        internal static readonly LocalKeyword Local = new LocalKeyword();
    }
}
