using CsCss.Descriptors;

namespace CsCss.AtRules.FontFace;

public sealed class FontFaceSrcDescriptor : Descriptor
{
    private FontFaceSrcDescriptor() : base("src") { }

    internal static readonly FontFaceSrcDescriptor Src = new();
}
