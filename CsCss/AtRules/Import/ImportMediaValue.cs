using CsCss.AtRules.Media;

namespace CsCss.AtRules.Import;

public sealed class ImportMediaValue
{
    private readonly string value;

    private ImportMediaValue(string value) => this.value = value;

    internal static ImportMediaValue Media(MediaQuery query) => new(query.ToString());

    public override string ToString() => value;
}
