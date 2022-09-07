using CsCss.Values;
using CsCss.Values.BaselinePosition;
using CsCss.Values.ContentDistribution;
using CsCss.Values.ContentPosition;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.OverflowPosition;
using CsCss.Values.Position;
using CsCss.Values.SelfPosition;

namespace CsCss.Properties.AlignSelf
{
    public class AlignSelfValue : Value
    {
        public AlignSelfValue(string v) : base(v) { }

        public static implicit operator AlignSelfValue(GlobalKeyword value)
        {
            return new AlignSelfValue(value.ToString());
        }

        public static implicit operator AlignSelfValue(AutoKeyword value)
        {
            return new AlignSelfValue(value.ToString());
        }

        public static implicit operator AlignSelfValue(NormalKeyword value)
        {
            return new AlignSelfValue(value.ToString());
        }

        public static implicit operator AlignSelfValue(StretchKeyword value)
        {
            return new AlignSelfValue(value.ToString());
        }

        public static implicit operator AlignSelfValue(BaselinePositionKeyword value)
        {
            return new AlignSelfValue(value.ToString());
        }

        public static implicit operator AlignSelfValue(CenterPositionValue value)
        {
            return new AlignSelfValue(value.ToString());
        }

        public static implicit operator AlignSelfValue(ContentPositionKeyword value)
        {
            return new AlignSelfValue(value.ToString());
        }

        public static implicit operator AlignSelfValue(SelfPositionKeyword value)
        {
            return new AlignSelfValue(value.ToString());
        }

        public static implicit operator AlignSelfValue((OverflowPositionKeyword overflowPosition, CenterPositionValue contentPosition) value)
        {
            return new AlignSelfValue(value.overflowPosition.ToString() + " " + value.contentPosition.ToString());
        }

        public static implicit operator AlignSelfValue((OverflowPositionKeyword overflowPosition, ContentPositionKeyword contentPosition) value)
        {
            return new AlignSelfValue(value.overflowPosition.ToString() + " " + value.contentPosition.ToString());
        }

        public static implicit operator AlignSelfValue((OverflowPositionKeyword overflowPosition, SelfPositionKeyword contentPosition) value)
        {
            return new AlignSelfValue(value.overflowPosition.ToString() + " " + value.contentPosition.ToString());
        }
    }
}
