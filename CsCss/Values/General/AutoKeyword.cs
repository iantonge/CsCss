namespace CsCss.Values.General
{
    public sealed class AutoKeyword : Value
    {
        private AutoKeyword() : base("auto") { }

        internal static readonly AutoKeyword Auto = new AutoKeyword();
    }
}
