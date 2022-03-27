using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.RepeatStyle;

namespace CsCss.Properties.BackgroundRepeat
{
    public class BackgroundRepeatValue : Value
    {
        public BackgroundRepeatValue(string v) : base(v) { }

        public static implicit operator BackgroundRepeatValue(GlobalKeyword value)
        {
            return new BackgroundRepeatValue(value.ToString());
        }

        public static implicit operator BackgroundRepeatValue(RepeatStyleKeyword value)
        {
            return new BackgroundRepeatValue(value.ToString());
        }

        public static implicit operator BackgroundRepeatValue((RepeatStyleKeyword horizontal, RepeatStyleKeyword vertical) value)
        {
            if (value.horizontal == RepeatStyleKeyword.RepeatX || value.vertical == RepeatStyleKeyword.RepeatX)
                throw new ArgumentException("RepeatX may only be used with the one-value syntax");
            if (value.horizontal == RepeatStyleKeyword.RepeatY || value.vertical == RepeatStyleKeyword.RepeatY)
                throw new ArgumentException("RepeatY may only be used with the one-value syntax");
            return new BackgroundRepeatValue(value.horizontal.ToString() + " " + value.vertical.ToString());
        }
    }
}
