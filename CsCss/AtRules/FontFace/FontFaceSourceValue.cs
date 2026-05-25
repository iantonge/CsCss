using CsCss.Values;
using CsCss.Values.String;
using CsCss.Values.Url;

namespace CsCss.AtRules.FontFace;

public sealed class FontFaceSourceValue : Value
{
    private FontFaceSourceValue(string value) : base(value) { }

    public static FontFaceSourceValue Local(StringValue name) => new($"local({name})");

    public static FontFaceSourceValue Url(UrlValue url) => new(url.ToString());

    public FontFaceSourceValue Format(StringValue format) => new($"{this} format({format})");
}
