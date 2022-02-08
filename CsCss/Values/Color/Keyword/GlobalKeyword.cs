using CsCss.Values.Text.Global;

namespace CsCss.Values.Color.Keyword
{
    public sealed class GlobalKeyword : ColorKeyword
    {
        private GlobalKeyword(string v) : base(v) { }

        public static implicit operator GlobalKeyword(Text.Global.GlobalKeyword value)
        {
            return new GlobalKeyword(value.ToString());
        }
    }
}
