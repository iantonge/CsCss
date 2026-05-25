using CsCss.Values;

namespace CsCss.AtRules.Property;

public sealed class PropertySyntaxValue : Value
{
    private PropertySyntaxValue(string value) : base(value) { }

    internal static readonly PropertySyntaxValue Any = new("\"*\"");
    internal static readonly PropertySyntaxValue Color = new("\"<color>\"");
    internal static readonly PropertySyntaxValue Length = new("\"<length>\"");
    internal static readonly PropertySyntaxValue LengthPercentage = new("\"<length-percentage>\"");
    internal static readonly PropertySyntaxValue Number = new("\"<number>\"");
    internal static readonly PropertySyntaxValue Percentage = new("\"<percentage>\"");
}
