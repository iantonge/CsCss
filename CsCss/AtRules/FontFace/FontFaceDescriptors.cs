using CsCss.Descriptors;
using CsCss.Values;

namespace CsCss.AtRules.FontFace;

public sealed class FontFaceDescriptors
{
    private readonly List<(Descriptor descriptor, Value value)> descriptors = new();

    public FontFamilyDescriptorValue this[FontFamilyDescriptor descriptor]
    {
        init
        {
            descriptors.Add((descriptor, value));
        }
    }

    public FontFaceSourceValue this[FontFaceSrcDescriptor descriptor]
    {
        init
        {
            descriptors.Add((descriptor, value));
        }
    }

    public FontStyleDescriptorValue this[FontStyleDescriptor descriptor]
    {
        init
        {
            descriptors.Add((descriptor, value));
        }
    }

    public FontWeightDescriptorValue this[FontWeightDescriptor descriptor]
    {
        init
        {
            descriptors.Add((descriptor, value));
        }
    }

    public FontDisplayValue this[FontDisplayDescriptor descriptor]
    {
        init
        {
            descriptors.Add((descriptor, value));
        }
    }

    internal IEnumerable<string> ToStrings()
    {
        foreach (var descriptor in descriptors)
        {
            yield return $"{descriptor.descriptor}: {descriptor.value}";
        }
    }
}
