using CsCss.Values.BaselinePosition;
using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.BaselinePosition
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBaselineKeyword()
        {
            Assert.Equal("baseline", Baseline.ToString());
            Assert.Equal(typeof(BaselinePositionKeyword), Baseline.GetType());
        }

        [Fact]
        public void RendersFirstBaselineKeyword()
        {
            Assert.Equal("first baseline", FirstBaseline.ToString());
            Assert.Equal(typeof(BaselinePositionKeyword), FirstBaseline.GetType());
        }

        [Fact]
        public void RendersLastBaselineKeyword()
        {
            Assert.Equal("last baseline", LastBaseline.ToString());
            Assert.Equal(typeof(BaselinePositionKeyword), LastBaseline.GetType());
        }
    }
}
