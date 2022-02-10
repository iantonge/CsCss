using CsCss.Values.General;

namespace CsCss.Values.Sizing
{
    public sealed class FitContentKeyword : Value
    {
        private FitContentKeyword() : base("fit-content") { }

        internal static readonly FitContentKeyword FitContent = new FitContentKeyword();
    }
}