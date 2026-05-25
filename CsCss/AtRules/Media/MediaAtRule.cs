using CsCss.Values.Length;

namespace CsCss.AtRules.Media;

public sealed class MediaAtRule
{
    private MediaAtRule() { }

    internal static readonly MediaAtRule Media = new();

    public RangeMediaFeature<LengthValue> Width { get; } = new("width");

    public RangeMediaFeature<LengthValue> Height { get; } = new("height");

    public IntegerRangeMediaFeature Color { get; } = new("color");

    public IntegerRangeMediaFeature Monochrome { get; } = new("monochrome");

    public MediaQuery All { get; } = new("all");

    public MediaQuery Screen { get; } = new("screen");

    public MediaQuery Print { get; } = new("print");

    public DiscreteMediaFeature Hover { get; } = new("hover");

    public DiscreteMediaFeature Pointer { get; } = new("pointer");

    public DiscreteMediaFeature PrefersReducedMotion { get; } = new("prefers-reduced-motion");

    public DiscreteMediaFeature Orientation { get; } = new("orientation");

    public MediaQuery Hovered { get; } = new("(hover: hover)");

    public MediaQuery NoHover { get; } = new("(hover: none)");

    public MediaQuery FinePointer { get; } = new("(pointer: fine)");

    public MediaQuery CoarsePointer { get; } = new("(pointer: coarse)");

    public MediaQuery ReducedMotion { get; } = new("(prefers-reduced-motion: reduce)");

    public MediaQuery NoMotionPreference { get; } = new("(prefers-reduced-motion: no-preference)");

    public MediaQuery Landscape { get; } = new("(orientation: landscape)");

    public MediaQuery Portrait { get; } = new("(orientation: portrait)");
}
