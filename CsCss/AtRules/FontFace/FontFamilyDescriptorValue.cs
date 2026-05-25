using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.String;

namespace CsCss.AtRules.FontFace;

public sealed class FontFamilyDescriptorValue : Value
{
    private FontFamilyDescriptorValue(string value) : base(value) { }

    public static implicit operator FontFamilyDescriptorValue(GlobalKeyword value) => new(value.ToString());

    public static implicit operator FontFamilyDescriptorValue(StringValue value) => new(value.ToString());

    public static implicit operator FontFamilyDescriptorValue(string value) => new(new StringValue(value).ToString());
}
