namespace CsCss.Values.RepeatStyle;

public sealed class RepeatStyleKeyword : Value
{
    private RepeatStyleKeyword(string v) : base(v) { }

    internal static readonly RepeatStyleKeyword RepeatX = new("repeat-x");
    internal static readonly RepeatStyleKeyword RepeatY = new("repeat-y");
    internal static readonly RepeatStyleKeyword Repeat = new("repeat");
    internal static readonly RepeatStyleKeyword Space = new("space");
    internal static readonly RepeatStyleKeyword Round = new("round");
    internal static readonly RepeatStyleKeyword NoRepeat = new("no-repeat");
}
