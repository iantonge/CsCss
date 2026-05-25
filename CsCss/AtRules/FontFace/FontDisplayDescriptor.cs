using CsCss.Descriptors;

namespace CsCss.AtRules.FontFace;

public sealed class FontDisplayDescriptor : Descriptor
{
    private FontDisplayDescriptor() : base("font-display") { }

    internal static readonly FontDisplayDescriptor FontDisplay = new();
}
