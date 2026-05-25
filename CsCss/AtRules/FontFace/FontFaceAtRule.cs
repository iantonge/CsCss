using CsCss.Values.String;
using CsCss.Values.Url;

namespace CsCss.AtRules.FontFace;

public sealed class FontFaceAtRule
{
    private FontFaceAtRule() { }

    internal static readonly FontFaceAtRule FontFace = new();

    public FontFamilyDescriptor Family { get; } = FontFamilyDescriptor.FontFamily;

    public FontFaceSrcDescriptor Src { get; } = FontFaceSrcDescriptor.Src;

    public FontStyleDescriptor Style { get; } = FontStyleDescriptor.FontStyle;

    public FontWeightDescriptor Weight { get; } = FontWeightDescriptor.FontWeight;

    public FontDisplayDescriptor Display { get; } = FontDisplayDescriptor.FontDisplay;

    public FontDisplayValue Auto { get; } = FontDisplayValue.Auto;

    public FontDisplayValue Block { get; } = FontDisplayValue.Block;

    public FontDisplayValue Swap { get; } = FontDisplayValue.Swap;

    public FontDisplayValue Fallback { get; } = FontDisplayValue.Fallback;

    public FontDisplayValue Optional { get; } = FontDisplayValue.Optional;

    public FontFaceSourceValue Local(StringValue name) => FontFaceSourceValue.Local(name);

    public FontFaceSourceValue Url(UrlValue url) => FontFaceSourceValue.Url(url);
}
