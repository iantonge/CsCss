using CsCss.Values.Percentage;

namespace CsCss.AtRules.Keyframes;

public sealed class KeyframeSelector
{
    private readonly string selector;

    private KeyframeSelector(string selector) => this.selector = selector;

    internal static readonly KeyframeSelector From = new("from");
    internal static readonly KeyframeSelector To = new("to");

    public override string ToString() => selector;

    public static implicit operator KeyframeSelector(PercentageValue percentage)
    {
        if (percentage.Number is null)
        {
            throw new ArgumentException("Keyframe selectors require a literal percentage.", nameof(percentage));
        }

        if (percentage.Number < 0 || percentage.Number > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(percentage), "Keyframe percentages must be between 0% and 100%.");
        }

        return new(percentage.ToString());
    }
}
