using CsCss.Values;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.String;

namespace CsCss.AtRules.FontFace;

public sealed class FontStyleDescriptorValue : Value
{
    private FontStyleDescriptorValue(string value) : base(value) { }

    public static implicit operator FontStyleDescriptorValue(GlobalKeyword value) => new(value.ToString());

    public static implicit operator FontStyleDescriptorValue(NormalKeyword value) => new(value.ToString());

    public static implicit operator FontStyleDescriptorValue(StringValue value) => new(value.ToString());

    public static implicit operator FontStyleDescriptorValue(string value) => new(new StringValue(value).ToString());
}
