namespace CsCss.Values.General
{
    public sealed class NormalKeyword : Value
    {
        private NormalKeyword() : base("normal") { }

        internal static readonly NormalKeyword Normal = new NormalKeyword();
    }
}
