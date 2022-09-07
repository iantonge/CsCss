using CsCss.Properties.AlignContent;
using Xunit;

namespace CsCss.Tests.Properties.AlignContent
{
    public class AlignContentValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            AlignContentValue converted = Initial;
            Assert.Equal("initial", converted.ToString());
        }
        [Fact]
        public void CanConvertFromNormalKeyword()
        {
            AlignContentValue converted = Normal;
            Assert.Equal("normal", converted.ToString());
        }

        [Fact]
        public void CanConvertFromBaselinePositionKeyword()
        {
            AlignContentValue converted = FirstBaseline;
            Assert.Equal("first baseline", converted.ToString());
        }

        [Fact]
        public void CanConvertFromContentDistributionKeyword()
        {
            AlignContentValue converted = SpaceAround;
            Assert.Equal("space-around", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterKeyword()
        {
            AlignContentValue converted = Center;
            Assert.Equal("center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromContentPositionKeyword()
        {
            AlignContentValue converted = FlexStart;
            Assert.Equal("flex-start", converted.ToString());
        }

        [Fact]
        public void CanConvertFromContentPositionKeywordWithOverflowPosition()
        {
            AlignContentValue converted = (Safe, FlexStart);
            Assert.Equal("safe flex-start", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterKeywordWithOverflowPosition()
        {
            AlignContentValue converted = (Unsafe, Center);
            Assert.Equal("unsafe center", converted.ToString());
        }
    }
}
