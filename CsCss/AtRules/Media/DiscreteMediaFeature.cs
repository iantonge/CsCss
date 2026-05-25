namespace CsCss.AtRules.Media;

public abstract class DiscreteMediaFeature
{
    private readonly string name;

    protected DiscreteMediaFeature(string name) => this.name = name;

    protected MediaQuery Value(string value) => new($"({name}: {value})");
}

public sealed class HoverMediaFeature : DiscreteMediaFeature
{
    internal HoverMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery Hover => Value("hover");
}

public sealed class PointerMediaFeature : DiscreteMediaFeature
{
    internal PointerMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery Coarse => Value("coarse");

    public MediaQuery Fine => Value("fine");
}

public sealed class OrientationMediaFeature : DiscreteMediaFeature
{
    internal OrientationMediaFeature(string name) : base(name) { }

    public MediaQuery Portrait => Value("portrait");

    public MediaQuery Landscape => Value("landscape");
}

public sealed class ReducedPreferenceMediaFeature : DiscreteMediaFeature
{
    internal ReducedPreferenceMediaFeature(string name) : base(name) { }

    public MediaQuery NoPreference => Value("no-preference");

    public MediaQuery Reduce => Value("reduce");
}

public sealed class ColorGamutMediaFeature : DiscreteMediaFeature
{
    internal ColorGamutMediaFeature(string name) : base(name) { }

    public MediaQuery Srgb => Value("srgb");

    public MediaQuery P3 => Value("p3");

    public MediaQuery Rec2020 => Value("rec2020");
}

public sealed class DisplayModeMediaFeature : DiscreteMediaFeature
{
    internal DisplayModeMediaFeature(string name) : base(name) { }

    public MediaQuery Fullscreen => Value("fullscreen");

    public MediaQuery Standalone => Value("standalone");

    public MediaQuery MinimalUi => Value("minimal-ui");

    public MediaQuery Browser => Value("browser");
}

public sealed class DynamicRangeMediaFeature : DiscreteMediaFeature
{
    internal DynamicRangeMediaFeature(string name) : base(name) { }

    public MediaQuery Standard => Value("standard");

    public MediaQuery High => Value("high");
}

public sealed class EnvironmentBlendingMediaFeature : DiscreteMediaFeature
{
    internal EnvironmentBlendingMediaFeature(string name) : base(name) { }

    public MediaQuery Opaque => Value("opaque");

    public MediaQuery Additive => Value("additive");

    public MediaQuery Subtractive => Value("subtractive");
}

public sealed class ForcedColorsMediaFeature : DiscreteMediaFeature
{
    internal ForcedColorsMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery Active => Value("active");
}

public sealed class InvertedColorsMediaFeature : DiscreteMediaFeature
{
    internal InvertedColorsMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery Inverted => Value("inverted");
}

public sealed class NavControlsMediaFeature : DiscreteMediaFeature
{
    internal NavControlsMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery Back => Value("back");
}

public sealed class OverflowBlockMediaFeature : DiscreteMediaFeature
{
    internal OverflowBlockMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery Scroll => Value("scroll");

    public MediaQuery OptionalPaged => Value("optional-paged");

    public MediaQuery Paged => Value("paged");
}

public sealed class OverflowInlineMediaFeature : DiscreteMediaFeature
{
    internal OverflowInlineMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery Scroll => Value("scroll");
}

public sealed class ColorSchemeMediaFeature : DiscreteMediaFeature
{
    internal ColorSchemeMediaFeature(string name) : base(name) { }

    public MediaQuery Light => Value("light");

    public MediaQuery Dark => Value("dark");
}

public sealed class ContrastMediaFeature : DiscreteMediaFeature
{
    internal ContrastMediaFeature(string name) : base(name) { }

    public MediaQuery NoPreference => Value("no-preference");

    public MediaQuery Less => Value("less");

    public MediaQuery More => Value("more");

    public MediaQuery Custom => Value("custom");
}

public sealed class ScanMediaFeature : DiscreteMediaFeature
{
    internal ScanMediaFeature(string name) : base(name) { }

    public MediaQuery Interlace => Value("interlace");

    public MediaQuery Progressive => Value("progressive");
}

public sealed class ScriptingMediaFeature : DiscreteMediaFeature
{
    internal ScriptingMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery InitialOnly => Value("initial-only");

    public MediaQuery Enabled => Value("enabled");
}

public sealed class UpdateMediaFeature : DiscreteMediaFeature
{
    internal UpdateMediaFeature(string name) : base(name) { }

    public MediaQuery None => Value("none");

    public MediaQuery Slow => Value("slow");

    public MediaQuery Fast => Value("fast");
}
