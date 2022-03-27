namespace CsCss.Values.General
{
    public sealed class TextKeyword : Value
    {
        private TextKeyword() : base("text") { }

        internal static readonly TextKeyword Text = new TextKeyword();
    }
}
