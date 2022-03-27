using CsCss.Values;
using CsCss.Values.Box;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.RepeatStyle;

namespace CsCss.Properties.BackgroundClip
{
    public class BackgroundClipValue : Value
    {
        public BackgroundClipValue(string v) : base(v) { }

        public static implicit operator BackgroundClipValue(GlobalKeyword value)
        {
            return new BackgroundClipValue(value.ToString());
        }

        public static implicit operator BackgroundClipValue(BoxKeyword value)
        {
            return new BackgroundClipValue(value.ToString());
        }

        public static implicit operator BackgroundClipValue(TextKeyword value)
        {
            return new BackgroundClipValue(value.ToString());
        }
    }
}
