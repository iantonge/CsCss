namespace CsCss.AtRules.Property;

public sealed class PropertyAtRule
{
    private PropertyAtRule() { }

    internal static readonly PropertyAtRule Property = new();

    public PropertySyntaxDescriptor Syntax { get; } = PropertySyntaxDescriptor.Syntax;

    public PropertyInheritsDescriptor Inherits { get; } = PropertyInheritsDescriptor.Inherits;

    public PropertyInitialValueDescriptor InitialValue { get; } = PropertyInitialValueDescriptor.InitialValue;

    public PropertySyntaxValue Any { get; } = PropertySyntaxValue.Any;

    public PropertySyntaxValue Color { get; } = PropertySyntaxValue.Color;

    public PropertySyntaxValue Length { get; } = PropertySyntaxValue.Length;

    public PropertySyntaxValue LengthPercentage { get; } = PropertySyntaxValue.LengthPercentage;

    public PropertySyntaxValue Number { get; } = PropertySyntaxValue.Number;

    public PropertySyntaxValue Percentage { get; } = PropertySyntaxValue.Percentage;
}
