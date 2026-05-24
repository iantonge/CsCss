using CsCss.Properties;
using CsCss.Values;

namespace CsCss;

public sealed partial class Declarations
{
    private readonly List<(Property property, Value value)> declarations = new();

    public IEnumerable<string> ToStrings()
    {
        foreach (var declaration in declarations)
        {
            yield return $"{declaration.property}: {declaration.value}";
        }
    }
}
