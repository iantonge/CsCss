namespace CsCss.AtRules.Import;

public sealed class ImportLayerValue
{
    private readonly string value;

    private ImportLayerValue(string value) => this.value = value;

    internal static readonly ImportLayerValue Anonymous = new("layer");

    internal static ImportLayerValue Named(string name)
    {
        if (!IsValidLayerName(name))
        {
            throw new ArgumentException("Layer names must be CSS identifiers.", nameof(name));
        }

        return new($"layer({name})");
    }

    public override string ToString() => value;

    private static bool IsValidLayerName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return false;
        }

        var parts = name.Split('.');
        foreach (var part in parts)
        {
            if (!IsValidIdentifier(part))
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsValidIdentifier(string value)
    {
        if (value.Length == 0)
        {
            return false;
        }

        var start = value[0] == '-' && value.Length > 1 ? 1 : 0;
        if (!IsNameStart(value[start]))
        {
            return false;
        }

        for (var i = start + 1; i < value.Length; i++)
        {
            if (!IsNameCharacter(value[i]))
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsNameStart(char value) => value is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or '_';

    private static bool IsNameCharacter(char value) => IsNameStart(value) || value is >= '0' and <= '9' or '-';
}
