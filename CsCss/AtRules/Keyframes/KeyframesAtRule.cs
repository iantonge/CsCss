namespace CsCss.AtRules.Keyframes;

public sealed class KeyframesAtRule
{
    private KeyframesAtRule() { }

    internal static readonly KeyframesAtRule Keyframes = new();

    public KeyframeSelector From { get; } = KeyframeSelector.From;

    public KeyframeSelector To { get; } = KeyframeSelector.To;
}
