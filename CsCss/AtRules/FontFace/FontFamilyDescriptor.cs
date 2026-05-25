using CsCss.Descriptors;

namespace CsCss.AtRules.FontFace;

public sealed class FontFamilyDescriptor : Descriptor
{
    private FontFamilyDescriptor() : base("font-family") { }

    internal static readonly FontFamilyDescriptor FontFamily = new();
}
