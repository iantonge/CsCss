using CsCss.Values.Url;

namespace CsCss;

public static partial class Functions
{
    public static UrlValue Url(string url) => new UrlValue($"url('{url}')");
}
