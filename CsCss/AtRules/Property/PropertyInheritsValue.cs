using CsCss.Values;

namespace CsCss.AtRules.Property;

public sealed class PropertyInheritsValue : Value
{
    private PropertyInheritsValue(string value) : base(value) { }

    public static implicit operator PropertyInheritsValue(bool value) => new(value ? "true" : "false");
}
