using CsCss.Values.Length;

namespace CsCss.AtRules.Media;

public static class MediaFeatures
{
    public static RangeMediaFeature<LengthValue> Width { get; } = new("width");

    public static RangeMediaFeature<LengthValue> Height { get; } = new("height");

    public static IntegerRangeMediaFeature Color { get; } = new("color");

    public static IntegerRangeMediaFeature Monochrome { get; } = new("monochrome");

    public static MediaQuery All { get; } = new("all");

    public static MediaQuery Screen { get; } = new("screen");

    public static MediaQuery Print { get; } = new("print");

    public static HoverMediaFeature Hover { get; } = new("hover");

    public static PointerMediaFeature Pointer { get; } = new("pointer");

    public static PointerMediaFeature AnyPointer { get; } = new("any-pointer");

    public static HoverMediaFeature AnyHover { get; } = new("any-hover");

    public static ReducedPreferenceMediaFeature PrefersReducedMotion { get; } = new("prefers-reduced-motion");

    public static OrientationMediaFeature Orientation { get; } = new("orientation");

    public static ColorGamutMediaFeature ColorGamut { get; } = new("color-gamut");

    public static DisplayModeMediaFeature DisplayMode { get; } = new("display-mode");

    public static DynamicRangeMediaFeature DynamicRange { get; } = new("dynamic-range");

    public static EnvironmentBlendingMediaFeature EnvironmentBlending { get; } = new("environment-blending");

    public static ForcedColorsMediaFeature ForcedColors { get; } = new("forced-colors");

    public static InvertedColorsMediaFeature InvertedColors { get; } = new("inverted-colors");

    public static NavControlsMediaFeature NavControls { get; } = new("nav-controls");

    public static OverflowBlockMediaFeature OverflowBlock { get; } = new("overflow-block");

    public static OverflowInlineMediaFeature OverflowInline { get; } = new("overflow-inline");

    public static ColorSchemeMediaFeature PrefersColorScheme { get; } = new("prefers-color-scheme");

    public static ContrastMediaFeature PrefersContrast { get; } = new("prefers-contrast");

    public static ContrastMediaFeature Contrast => PrefersContrast;

    public static ReducedPreferenceMediaFeature PrefersReducedData { get; } = new("prefers-reduced-data");

    public static ReducedPreferenceMediaFeature PrefersReducedTransparency { get; } = new("prefers-reduced-transparency");

    public static ScanMediaFeature Scan { get; } = new("scan");

    public static ScriptingMediaFeature Scripting { get; } = new("scripting");

    public static UpdateMediaFeature Update { get; } = new("update");

    public static ColorGamutMediaFeature VideoColorGamut { get; } = new("video-color-gamut");

    public static DynamicRangeMediaFeature VideoDynamicRange { get; } = new("video-dynamic-range");

    public static MediaQuery Hovered => Hover.Hover;

    public static MediaQuery NoHover => Hover.None;

    public static MediaQuery FinePointer => Pointer.Fine;

    public static MediaQuery CoarsePointer => Pointer.Coarse;

    public static MediaQuery ReducedMotion => PrefersReducedMotion.Reduce;

    public static MediaQuery NoMotionPreference => PrefersReducedMotion.NoPreference;

    public static MediaQuery Landscape => Orientation.Landscape;

    public static MediaQuery Portrait => Orientation.Portrait;
}
