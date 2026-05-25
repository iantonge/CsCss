using CsCss.AtRules.Media;
using CsCss.Values.Url;

namespace CsCss.AtRules.Import;

public sealed class ImportValue
{
    private readonly string value;

    private ImportValue(string value) => this.value = value;

    internal static ImportValue Url(UrlValue url) => new(url.ToString());

    public ImportValue Layer(string name) => Add(ImportLayerValue.Named(name));

    public ImportValue Layer() => Add(ImportLayerValue.Anonymous);

    public ImportValue Media(MediaQuery query) => Add(ImportMediaValue.Media(query));

    public override string ToString() => value;

    private ImportValue Add(object modifier) => new($"{value} {modifier}");
}
