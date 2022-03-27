using CsCss.Values;
using CsCss.Values.Box;
using CsCss.Values.Global;

namespace CsCss.Properties.BackgroundOrigin
{
    public class BackgroundOriginValue : Value
    {
        public BackgroundOriginValue(string v) : base(v) { }

        public static implicit operator BackgroundOriginValue(GlobalKeyword value)
        {
            return new BackgroundOriginValue(value.ToString());
        }

        public static implicit operator BackgroundOriginValue(BoxKeyword value)
        {
            return new BackgroundOriginValue(value.ToString());
        }
    }
}
