using System.Text;

namespace CsCss.AtRules.FontFace;

internal sealed class FontFaceRule : CssRule
{
    private readonly FontFaceDescriptors descriptors;

    internal FontFaceRule(FontFaceDescriptors descriptors)
    {
        this.descriptors = descriptors;
    }

    internal override void AppendTo(StringBuilder sb, int indentLevel)
    {
        sb.Append(Indent(indentLevel));
        sb.Append("@font-face {");
        foreach (var descriptor in descriptors.ToStrings())
        {
            sb.Append('\n');
            sb.Append(Indent(indentLevel + 1));
            sb.Append(descriptor);
            sb.Append(';');
        }
        sb.Append('\n');
        sb.Append(Indent(indentLevel));
        sb.Append('}');
    }
}
