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

    public HoverMediaFeature Hover { get; } = new("hover");

    public PointerMediaFeature Pointer { get; } = new("pointer");

    public PointerMediaFeature AnyPointer { get; } = new("any-pointer");

    public HoverMediaFeature AnyHover { get; } = new("any-hover");

    public ReducedPreferenceMediaFeature PrefersReducedMotion { get; } = new("prefers-reduced-motion");

    public OrientationMediaFeature Orientation { get; } = new("orientation");

    public ColorGamutMediaFeature ColorGamut { get; } = new("color-gamut");

    public DisplayModeMediaFeature DisplayMode { get; } = new("display-mode");

    public DynamicRangeMediaFeature DynamicRange { get; } = new("dynamic-range");

    public EnvironmentBlendingMediaFeature EnvironmentBlending { get; } = new("environment-blending");

    public ForcedColorsMediaFeature ForcedColors { get; } = new("forced-colors");

    public InvertedColorsMediaFeature InvertedColors { get; } = new("inverted-colors");

    public NavControlsMediaFeature NavControls { get; } = new("nav-controls");

    public OverflowBlockMediaFeature OverflowBlock { get; } = new("overflow-block");

    public OverflowInlineMediaFeature OverflowInline { get; } = new("overflow-inline");

    public ColorSchemeMediaFeature PrefersColorScheme { get; } = new("prefers-color-scheme");

    public ContrastMediaFeature PrefersContrast { get; } = new("prefers-contrast");

    public ContrastMediaFeature Contrast => PrefersContrast;

    public ReducedPreferenceMediaFeature PrefersReducedData { get; } = new("prefers-reduced-data");

    public ReducedPreferenceMediaFeature PrefersReducedTransparency { get; } = new("prefers-reduced-transparency");

    public ScanMediaFeature Scan { get; } = new("scan");

    public ScriptingMediaFeature Scripting { get; } = new("scripting");

    public UpdateMediaFeature Update { get; } = new("update");

    public ColorGamutMediaFeature VideoColorGamut { get; } = new("video-color-gamut");

    public DynamicRangeMediaFeature VideoDynamicRange { get; } = new("video-dynamic-range");

    public MediaQuery Hovered => Hover.Hover;

    public MediaQuery NoHover => Hover.None;

    public MediaQuery FinePointer => Pointer.Fine;

    public MediaQuery CoarsePointer => Pointer.Coarse;

    public MediaQuery ReducedMotion => PrefersReducedMotion.Reduce;

    public MediaQuery NoMotionPreference => PrefersReducedMotion.NoPreference;

    public MediaQuery Landscape => Orientation.Landscape;

    public MediaQuery Portrait => Orientation.Portrait;
}
