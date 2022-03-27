using CsCss.Values;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Gradient;
using CsCss.Values.Url;

namespace CsCss.Properties.BackgroundImage
{
    public class BackgroundImageValue : Value
    {
        public BackgroundImageValue(string v) : base(v) { }

        public static implicit operator BackgroundImageValue(GlobalKeyword value)
        {
            return new BackgroundImageValue(value.ToString());
        }

        public static implicit operator BackgroundImageValue(NoneKeyword value)
        {
            return new BackgroundImageValue(value.ToString());
        }

        public static implicit operator BackgroundImageValue(UrlValue value)
        {
            return new BackgroundImageValue(value.ToString());
        }

        public static implicit operator BackgroundImageValue(GradientValue value)
        {
            return new BackgroundImageValue(value.ToString());
        }
    }
}
