namespace CsCss.AtRules.Keyframes;

internal sealed class KeyframesRule : CssRule
{
    private readonly string name;
    private readonly Keyframes keyframes;

    internal KeyframesRule(string name, Keyframes keyframes)
    {
        if (!IsValidName(name))
        {
            throw new ArgumentException("Keyframes names must be CSS identifiers and cannot be none.", nameof(name));
        }

        this.name = name;
        this.keyframes = keyframes;
    }

    internal override void WriteTo(CssWriter writer, int indentLevel)
    {
        writer.WriteIndent(indentLevel);
        writer.Write("@keyframes ");
        writer.Write(name);
        writer.WriteSpace();
        writer.Write('{');
        foreach (var block in keyframes.Blocks)
        {
            writer.WriteLine();
            writer.WriteIndent(indentLevel + 1);
            writer.Write(block.selector.ToString());
            writer.WriteSpace();
            writer.Write('{');
            foreach (var declaration in block.declarations.Items)
            {
                writer.WriteLine();
                writer.WriteIndent(indentLevel + 2);
                writer.Write(declaration.property.ToString());
                writer.Write(':');
                writer.WriteSpace();
                writer.Write(declaration.value.ToString());
                writer.Write(';');
            }
            writer.WriteLine();
            writer.WriteIndent(indentLevel + 1);
            writer.Write('}');
        }
        writer.WriteLine();
        writer.WriteIndent(indentLevel);
        writer.Write('}');
    }

    private static bool IsValidName(string name)
    {
        if (string.IsNullOrWhiteSpace(name) || string.Equals(name, "none", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var start = name[0] == '-' && name.Length > 1 ? 1 : 0;
        if (!IsNameStart(name[start]))
        {
            return false;
        }

        for (var i = start + 1; i < name.Length; i++)
        {
            if (!IsNameCharacter(name[i]))
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsNameStart(char value) => value is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or '_';

    private static bool IsNameCharacter(char value) => IsNameStart(value) || value is >= '0' and <= '9' or '-';
}
