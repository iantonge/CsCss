using CsCss.Properties.AlignItems;
using Xunit;

namespace CsCss.Tests.Properties.AlignItems
{
    public class AlignItemsValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            AlignItemsValue converted = Initial;
            Assert.Equal("initial", converted.ToString());
        }
        [Fact]
        public void CanConvertFromNormalKeyword()
        {
            AlignItemsValue converted = Normal;
            Assert.Equal("normal", converted.ToString());
        }

        [Fact]
        public void CanConvertFromBaselinePositionKeyword()
        {
            AlignItemsValue converted = FirstBaseline;
            Assert.Equal("first baseline", converted.ToString());
        }

        [Fact]
        public void CanConvertFromStretchKeyword()
        {
            AlignItemsValue converted = Stretch;
            Assert.Equal("stretch", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterKeyword()
        {
            AlignItemsValue converted = Center;
            Assert.Equal("center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromContentPositionKeyword()
        {
            AlignItemsValue converted = FlexStart;
            Assert.Equal("flex-start", converted.ToString());
        }

        [Fact]
        public void CanConvertFromSelfPositionKeyword()
        {
            AlignItemsValue converted = SelfStart;
            Assert.Equal("self-start", converted.ToString());
        }

        [Fact]
        public void CanConvertFromContentPositionKeywordWithOverflowPosition()
        {
            AlignItemsValue converted = (Safe, FlexStart);
            Assert.Equal("safe flex-start", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterKeywordWithOverflowPosition()
        {
            AlignItemsValue converted = (Unsafe, Center);
            Assert.Equal("unsafe center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromSelfPositionKeywordWithOverflowPosition()
        {
            AlignItemsValue converted = (Safe, SelfStart);
            Assert.Equal("safe self-start", converted.ToString());
        }
    }
}
