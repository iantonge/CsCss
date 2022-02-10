using CsCss.Values;
using CsCss.Values.Numeric.FitContent;
using CsCss.Values.Numeric.Length;
using CsCss.Values.Numeric.LengthPercentage;
using CsCss.Values.Numeric.Percentage;
using CsCss.Values.Text.Global;
using CsCss.Values.Text.Keyword;
using CsCss.Values.Text.Keyword.Sizing;

namespace CsCss.Properties.Height
{
    public class HeightValue : Value
    {
        private HeightValue(string value) : base(value) { }

        public static implicit operator HeightValue(GlobalKeyword value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(AutoKeyword value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(MinContentKeyword value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(MaxContentKeyword value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(FitContentKeyword value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(FitContentValue value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(PercentageValue value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(LengthValue value)
        {
            return new HeightValue(value.ToString());
        }

        public static implicit operator HeightValue(LengthPercentageValue value)
        {
            return new HeightValue(value.ToString());
        }
    }
}
