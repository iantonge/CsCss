using CsCss.Descriptors;

namespace CsCss.AtRules.FontFace;

public sealed class FontWeightDescriptor : Descriptor
{
    private FontWeightDescriptor() : base("font-weight") { }

    internal static readonly FontWeightDescriptor FontWeight = new();
}
