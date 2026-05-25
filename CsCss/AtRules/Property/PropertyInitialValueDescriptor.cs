using CsCss.Descriptors;

namespace CsCss.AtRules.Property;

public sealed class PropertyInitialValueDescriptor : Descriptor
{
    private PropertyInitialValueDescriptor() : base("initial-value") { }

    internal static readonly PropertyInitialValueDescriptor InitialValue = new();
}
