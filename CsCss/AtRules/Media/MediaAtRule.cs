namespace CsCss.AtRules.Media;

public sealed class MediaAtRule
{
    private MediaAtRule() { }

    internal static readonly MediaAtRule Media = new();

    public MediaFeature Width { get; } = new("width");

    public MediaQuery All { get; } = new("all");

    public MediaQuery Screen { get; } = new("screen");

    public MediaQuery Print { get; } = new("print");

    public MediaQuery Hover { get; } = new("(hover: hover)");

    public MediaQuery NoHover { get; } = new("(hover: none)");

    public MediaQuery Pointer { get; } = new("(pointer: fine)");

    public MediaQuery ReducedMotion { get; } = new("(prefers-reduced-motion: reduce)");

    public MediaQuery Landscape { get; } = new("(orientation: landscape)");
}
