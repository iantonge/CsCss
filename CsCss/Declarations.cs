using CsCss.Properties;
using CsCss.Values;

namespace CsCss;

public sealed partial class Declarations
{
    private readonly List<(Property property, Value value)> declarations = new();

    internal IReadOnlyList<(Property property, Value value)> Items => declarations;
}
