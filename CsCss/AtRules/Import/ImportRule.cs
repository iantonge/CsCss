using System.Text;

namespace CsCss.AtRules.Import;

internal sealed class ImportRule : CssRule
{
    private readonly ImportValue import;

    internal ImportRule(ImportValue import)
    {
        this.import = import;
    }

    internal override bool IsImportRule => true;

    internal override void AppendTo(StringBuilder sb, int indentLevel)
    {
        sb.Append(Indent(indentLevel));
        sb.Append("@import ");
        sb.Append(import);
        sb.Append(';');
    }
}
