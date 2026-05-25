namespace CsCss;

internal abstract class CssRule
{
    internal virtual bool IsImportRule => false;

    internal abstract void WriteTo(CssWriter writer, int indentLevel);
}
