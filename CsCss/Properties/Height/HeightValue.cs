using CsCss.Values;
using CsCss.Values.Sizing;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;
using CsCss.Values.Global;
using CsCss.Values.General;

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
