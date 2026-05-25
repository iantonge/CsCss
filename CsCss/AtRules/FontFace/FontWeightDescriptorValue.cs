using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.String;

namespace CsCss.AtRules.FontFace;

public sealed class FontWeightDescriptorValue : Value
{
    private FontWeightDescriptorValue(string value) : base(value) { }

    public static implicit operator FontWeightDescriptorValue(GlobalKeyword value) => new(value.ToString());

    public static implicit operator FontWeightDescriptorValue(StringValue value) => new(value.ToString());

    public static implicit operator FontWeightDescriptorValue(string value) => new(new StringValue(value).ToString());

    public static implicit operator FontWeightDescriptorValue(int value) => new(value.ToString());

    public static implicit operator FontWeightDescriptorValue((int min, int max) value) => new($"{value.min} {value.max}");
}
