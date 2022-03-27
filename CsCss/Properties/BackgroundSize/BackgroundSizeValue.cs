using CsCss.Values;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;
using CsCss.Values.Sizing;

namespace CsCss.Properties.BackgroundSize
{
    public class BackgroundSizeValue : Value
    {
        public BackgroundSizeValue(string v) : base(v) { }

        public static implicit operator BackgroundSizeValue(GlobalKeyword value)
        {
            return new BackgroundSizeValue(value.ToString());
        }

        public static implicit operator BackgroundSizeValue(ContainKeyword value)
        {
            return new BackgroundSizeValue(value.ToString());
        }

        public static implicit operator BackgroundSizeValue(CoverKeyword value)
        {
            return new BackgroundSizeValue(value.ToString());
        }

        public static implicit operator BackgroundSizeValue(AutoKeyword value)
        {
            return new BackgroundSizeValue(value.ToString());
        }

        public static implicit operator BackgroundSizeValue((AutoKeyword width, AutoKeyword height) value)
        {
            return new BackgroundSizeValue(value.width.ToString() + " " + value.height.ToString());
        }

        public static implicit operator BackgroundSizeValue((AutoKeyword width, LengthPercentageValue height) value)
        {
            return new BackgroundSizeValue(value.width.ToString() + " " + value.height.ToString());
        }

        public static implicit operator BackgroundSizeValue(LengthValue value)
        {
            return new BackgroundSizeValue(value.ToString());
        }

        public static implicit operator BackgroundSizeValue(PercentageValue value)
        {
            return new BackgroundSizeValue(value.ToString());
        }

        public static implicit operator BackgroundSizeValue(LengthPercentageValue value)
        {
            return new BackgroundSizeValue(value.ToString());
        }

        public static implicit operator BackgroundSizeValue((LengthPercentageValue width, AutoKeyword height) value)
        {
            return new BackgroundSizeValue(value.width.ToString() + " " + value.height.ToString());
        }

        public static implicit operator BackgroundSizeValue((LengthPercentageValue width, LengthPercentageValue height) value)
        {
            return new BackgroundSizeValue(value.width.ToString() + " " + value.height.ToString());
        }
    }
}
