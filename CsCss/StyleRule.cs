namespace CsCss;

internal sealed class StyleRule : CssRule
{
    private readonly Selector selector;
    private readonly Declarations declarations;

    internal StyleRule(Selector selector, Declarations declarations)
    {
        this.selector = selector;
        this.declarations = declarations;
    }

    internal override void WriteTo(CssWriter writer, int indentLevel)
    {
        writer.WriteIndent(indentLevel);
        writer.Write(selector.ToString());
        writer.WriteSpace();
        writer.Write('{');
        foreach (var declaration in declarations.Items)
        {
            writer.WriteLine();
            writer.WriteIndent(indentLevel + 1);
            writer.Write(declaration.property.ToString());
            writer.Write(':');
            writer.WriteSpace();
            writer.Write(declaration.value.ToString());
            writer.Write(';');
        }
        writer.WriteLine();
        writer.WriteIndent(indentLevel);
        writer.Write('}');
    }
}
