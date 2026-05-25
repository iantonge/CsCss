using System.Text;

namespace CsCss.AtRules.Property;

internal sealed class PropertyRule : CssRule
{
    private readonly string name;
    private readonly PropertyDescriptors descriptors;

    internal PropertyRule(string name, PropertyDescriptors descriptors)
    {
        if (!IsValidCustomPropertyName(name))
        {
            throw new ArgumentException("Property names must be custom property names that start with --.", nameof(name));
        }

        this.name = name;
        this.descriptors = descriptors;
    }

    internal override void AppendTo(StringBuilder sb, int indentLevel)
    {
        sb.Append(Indent(indentLevel));
        sb.Append("@property ");
        sb.Append(name);
        sb.Append(" {");
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

    private static bool IsValidCustomPropertyName(string name)
    {
        if (name.Length <= 2 || !name.StartsWith("--", StringComparison.Ordinal))
        {
            return false;
        }

        for (var i = 2; i < name.Length; i++)
        {
            if (!IsNameCharacter(name[i]))
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsNameCharacter(char value)
        => value is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9' or '-' or '_';
}
