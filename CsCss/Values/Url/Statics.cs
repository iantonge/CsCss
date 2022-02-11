using CsCss.Values.Url;

namespace CsCss
{
    public static partial class Statics
    {
        public static UrlValue Url(string url)
        {
            return new UrlValue("url('" + url + "')");
        }
    }
}
