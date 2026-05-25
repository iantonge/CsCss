namespace CsCss.AtRules.Import;

internal sealed class ImportRule : CssRule
{
    private readonly ImportValue import;

    internal ImportRule(ImportValue import)
    {
        this.import = import;
    }

    internal override bool IsImportRule => true;

    internal override void WriteTo(CssWriter writer, int indentLevel)
    {
        writer.WriteIndent(indentLevel);
        writer.Write("@import ");
        writer.Write(import.ToString());
        writer.Write(';');
    }
}
