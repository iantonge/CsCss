namespace CsCss.AtRules.Keyframes;

public sealed class Keyframes
{
    internal readonly List<(KeyframeSelector selector, Declarations declarations)> Blocks = new();

    public Declarations this[KeyframeSelector selector]
    {
        init
        {
            Blocks.Add((selector, value));
        }
    }
}
