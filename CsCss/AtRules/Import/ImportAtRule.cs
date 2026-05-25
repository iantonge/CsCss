using CsCss.AtRules.Media;
using CsCss.Values.Url;

namespace CsCss.AtRules.Import;

public sealed class ImportAtRule
{
    private ImportAtRule() { }

    internal static readonly ImportAtRule Import = new();

    public ImportValue Url(UrlValue url) => ImportValue.Url(url);

    public ImportLayerValue Layer(string name) => ImportLayerValue.Named(name);

    public ImportLayerValue Layer() => ImportLayerValue.Anonymous;

    public ImportMediaValue Media(MediaQuery query) => ImportMediaValue.Media(query);
}
