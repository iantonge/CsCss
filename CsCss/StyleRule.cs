using System.Text;

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

    internal override void AppendTo(StringBuilder sb, int indentLevel)
    {
        sb.Append(Indent(indentLevel));
        sb.Append(selector);
        sb.Append(" {");
        foreach (var declaration in declarations.ToStrings())
        {
            sb.Append('\n');
            sb.Append(Indent(indentLevel + 1));
            sb.Append(declaration);
            sb.Append(';');
        }
        sb.Append('\n');
        sb.Append(Indent(indentLevel));
        sb.Append('}');
    }
}
