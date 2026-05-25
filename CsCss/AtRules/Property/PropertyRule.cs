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

    internal override void WriteTo(CssWriter writer, int indentLevel)
    {
        writer.WriteIndent(indentLevel);
        writer.Write("@property ");
        writer.Write(name);
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
