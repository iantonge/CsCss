using System.Text;

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

    internal override void AppendTo(StringBuilder sb, int indentLevel)
    {
        sb.Append(Indent(indentLevel));
        sb.Append("@keyframes ");
        sb.Append(name);
        sb.Append(" {");
        foreach (var block in keyframes.Blocks)
        {
            sb.Append('\n');
            sb.Append(Indent(indentLevel + 1));
            sb.Append(block.selector);
            sb.Append(" {");
            foreach (var declaration in block.declarations.ToStrings())
            {
                sb.Append('\n');
                sb.Append(Indent(indentLevel + 2));
                sb.Append(declaration);
                sb.Append(';');
            }
            sb.Append('\n');
            sb.Append(Indent(indentLevel + 1));
            sb.Append('}');
        }
        sb.Append('\n');
        sb.Append(Indent(indentLevel));
        sb.Append('}');
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
