using CsCss.Descriptors;

namespace CsCss.AtRules.Property;

public sealed class PropertySyntaxDescriptor : Descriptor
{
    private PropertySyntaxDescriptor() : base("syntax") { }

    internal static readonly PropertySyntaxDescriptor Syntax = new();
}
