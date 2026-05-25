using CsCss.Descriptors;
using CsCss.Values;

namespace CsCss.AtRules.Property;

public sealed class PropertyDescriptors
{
    private readonly List<(Descriptor descriptor, Value value)> descriptors = new();

    public PropertySyntaxValue this[PropertySyntaxDescriptor descriptor]
    {
        init
        {
            descriptors.Add((descriptor, value));
        }
    }

    public PropertyInheritsValue this[PropertyInheritsDescriptor descriptor]
    {
        init
        {
            descriptors.Add((descriptor, value));
        }
    }

    public Value this[PropertyInitialValueDescriptor descriptor]
    {
        init
        {
            descriptors.Add((descriptor, value));
        }
    }

    internal IReadOnlyList<(Descriptor descriptor, Value value)> Items => descriptors;
}
