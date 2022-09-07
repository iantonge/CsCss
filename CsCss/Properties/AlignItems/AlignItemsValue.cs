using CsCss.Values;
using CsCss.Values.BaselinePosition;
using CsCss.Values.ContentDistribution;
using CsCss.Values.ContentPosition;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.OverflowPosition;
using CsCss.Values.Position;
using CsCss.Values.SelfPosition;

namespace CsCss.Properties.AlignItems
{
    public class AlignItemsValue : Value
    {
        public AlignItemsValue(string v) : base(v) { }

        public static implicit operator AlignItemsValue(GlobalKeyword value)
        {
            return new AlignItemsValue(value.ToString());
        }

        public static implicit operator AlignItemsValue(NormalKeyword value)
        {
            return new AlignItemsValue(value.ToString());
        }

        public static implicit operator AlignItemsValue(StretchKeyword value)
        {
            return new AlignItemsValue(value.ToString());
        }

        public static implicit operator AlignItemsValue(BaselinePositionKeyword value)
        {
            return new AlignItemsValue(value.ToString());
        }

        public static implicit operator AlignItemsValue(CenterPositionValue value)
        {
            return new AlignItemsValue(value.ToString());
        }

        public static implicit operator AlignItemsValue(ContentPositionKeyword value)
        {
            return new AlignItemsValue(value.ToString());
        }

        public static implicit operator AlignItemsValue(SelfPositionKeyword value)
        {
            return new AlignItemsValue(value.ToString());
        }

        public static implicit operator AlignItemsValue((OverflowPositionKeyword overflowPosition, CenterPositionValue contentPosition) value)
        {
            return new AlignItemsValue(value.overflowPosition.ToString() + " " + value.contentPosition.ToString());
        }

        public static implicit operator AlignItemsValue((OverflowPositionKeyword overflowPosition, ContentPositionKeyword contentPosition) value)
        {
            return new AlignItemsValue(value.overflowPosition.ToString() + " " + value.contentPosition.ToString());
        }

        public static implicit operator AlignItemsValue((OverflowPositionKeyword overflowPosition, SelfPositionKeyword contentPosition) value)
        {
            return new AlignItemsValue(value.overflowPosition.ToString() + " " + value.contentPosition.ToString());
        }
    }
}
