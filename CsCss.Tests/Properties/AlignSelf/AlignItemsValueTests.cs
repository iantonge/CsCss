using CsCss.Properties.AlignSelf;
using Xunit;

namespace CsCss.Tests.Properties.AlignSelf
{
    public class AlignSelfValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            AlignSelfValue converted = Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromNormalKeyword()
        {
            AlignSelfValue converted = Normal;
            Assert.Equal("normal", converted.ToString());
        }

        [Fact]
        public void CanConvertFromAutoKeyword()
        {
            AlignSelfValue converted = Auto;
            Assert.Equal("auto", converted.ToString());
        }

        [Fact]
        public void CanConvertFromBaselinePositionKeyword()
        {
            AlignSelfValue converted = FirstBaseline;
            Assert.Equal("first baseline", converted.ToString());
        }

        [Fact]
        public void CanConvertFromStretchKeyword()
        {
            AlignSelfValue converted = Stretch;
            Assert.Equal("stretch", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterKeyword()
        {
            AlignSelfValue converted = Center;
            Assert.Equal("center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromContentPositionKeyword()
        {
            AlignSelfValue converted = FlexStart;
            Assert.Equal("flex-start", converted.ToString());
        }

        [Fact]
        public void CanConvertFromSelfPositionKeyword()
        {
            AlignSelfValue converted = SelfStart;
            Assert.Equal("self-start", converted.ToString());
        }

        [Fact]
        public void CanConvertFromContentPositionKeywordWithOverflowPosition()
        {
            AlignSelfValue converted = (Safe, FlexStart);
            Assert.Equal("safe flex-start", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterKeywordWithOverflowPosition()
        {
            AlignSelfValue converted = (Unsafe, Center);
            Assert.Equal("unsafe center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromSelfPositionKeywordWithOverflowPosition()
        {
            AlignSelfValue converted = (Safe, SelfStart);
            Assert.Equal("safe self-start", converted.ToString());
        }
    }
}
