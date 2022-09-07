using CsCss.Values;
using CsCss.Values.BaselinePosition;
using CsCss.Values.ContentDistribution;
using CsCss.Values.ContentPosition;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.OverflowPosition;
using CsCss.Values.Position;

namespace CsCss.Properties.AlignContent
{
    public class AlignContentValue : Value
    {
        public AlignContentValue(string v) : base(v) { }

        public static implicit operator AlignContentValue(NormalKeyword value)
        {
            return new AlignContentValue(value.ToString());
        }

        public static implicit operator AlignContentValue(GlobalKeyword value)
        {
            return new AlignContentValue(value.ToString());
        }

        public static implicit operator AlignContentValue(BaselinePositionKeyword value)
        {
            return new AlignContentValue(value.ToString());
        }

        public static implicit operator AlignContentValue(ContentDistributionKeyword value)
        {
            return new AlignContentValue(value.ToString());
        }

        public static implicit operator AlignContentValue(StretchKeyword value)
        {
            return new AlignContentValue(value.ToString());
        }

        public static implicit operator AlignContentValue(CenterPositionValue value)
        {
            return new AlignContentValue(value.ToString());
        }

        public static implicit operator AlignContentValue(ContentPositionKeyword value)
        {
            return new AlignContentValue(value.ToString());
        }

        public static implicit operator AlignContentValue((OverflowPositionKeyword overflowPosition, CenterPositionValue contentPosition) value)
        {
            return new AlignContentValue(value.overflowPosition.ToString() + " " + value.contentPosition.ToString());
        }

        public static implicit operator AlignContentValue((OverflowPositionKeyword overflowPosition, ContentPositionKeyword contentPosition) value)
        {
            return new AlignContentValue(value.overflowPosition.ToString() + " " + value.contentPosition.ToString());
        }
    }
}
