using CsCss.Values.General;

namespace CsCss.Values.Sizing
{
    public sealed class MaxContentKeyword : Keyword
    {
        private MaxContentKeyword() : base("max-content") { }

        internal static readonly MaxContentKeyword MaxContent = new MaxContentKeyword();
    }
}
