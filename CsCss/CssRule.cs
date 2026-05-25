using System.Text;

namespace CsCss;

internal abstract class CssRule
{
    internal virtual bool IsImportRule => false;

    internal abstract void AppendTo(StringBuilder sb, int indentLevel);

    protected static string Indent(int indentLevel) => new(' ', indentLevel * 4);
}
