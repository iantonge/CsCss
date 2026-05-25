namespace CsCss.AtRules.FontFace;

internal sealed class FontFaceRule : CssRule
{
    private readonly FontFaceDescriptors descriptors;

    internal FontFaceRule(FontFaceDescriptors descriptors)
    {
        this.descriptors = descriptors;
    }

    internal override void WriteTo(CssWriter writer, int indentLevel)
    {
        writer.WriteIndent(indentLevel);
        writer.Write("@font-face");
        writer.WriteSpace();
        writer.Write('{');
        foreach (var descriptor in descriptors.Items)
        {
            writer.WriteLine();
            writer.WriteIndent(indentLevel + 1);
            writer.Write(descriptor.descriptor.ToString());
            writer.Write(':');
            writer.WriteSpace();
            writer.Write(descriptor.value.ToString());
            writer.Write(';');
        }
        writer.WriteLine();
        writer.WriteIndent(indentLevel);
        writer.Write('}');
    }
}
