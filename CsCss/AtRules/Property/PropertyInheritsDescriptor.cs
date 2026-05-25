using CsCss.Descriptors;

namespace CsCss.AtRules.Property;

public sealed class PropertyInheritsDescriptor : Descriptor
{
    private PropertyInheritsDescriptor() : base("inherits") { }

    internal static readonly PropertyInheritsDescriptor Inherits = new();
}
