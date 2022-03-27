namespace CsCss.Values.RepeatStyle
{
    public sealed class RepeatStyleKeyword : Value
    {
        private RepeatStyleKeyword(string v) : base(v) { }

        internal static readonly RepeatStyleKeyword RepeatX = new RepeatStyleKeyword("repeat-x");
        internal static readonly RepeatStyleKeyword RepeatY = new RepeatStyleKeyword("repeat-y");
        internal static readonly RepeatStyleKeyword Repeat = new RepeatStyleKeyword("repeat");
        internal static readonly RepeatStyleKeyword Space = new RepeatStyleKeyword("space");
        internal static readonly RepeatStyleKeyword Round = new RepeatStyleKeyword("round");
        internal static readonly RepeatStyleKeyword NoRepeat = new RepeatStyleKeyword("no-repeat");
    }
}
