using CsCss.Descriptors;

namespace CsCss.AtRules.FontFace;

public sealed class FontStyleDescriptor : Descriptor
{
    private FontStyleDescriptor() : base("font-style") { }

    internal static readonly FontStyleDescriptor FontStyle = new();
}
