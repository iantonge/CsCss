using CsCss.Values.Box;
using CsCss.Values.ContentDistribution;
using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.ContentDistribution
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersSpaceBetweenKeyword()
        {
            Assert.Equal("space-between", SpaceBetween.ToString());
            Assert.Equal(typeof(ContentDistributionKeyword), SpaceBetween.GetType());
        }

        [Fact]
        public void RendersSpaceAroundKeyword()
        {
            Assert.Equal("space-around", SpaceAround.ToString());
            Assert.Equal(typeof(ContentDistributionKeyword), SpaceAround.GetType());
        }

        [Fact]
        public void RendersSpaceEvenlyKeyword()
        {
            Assert.Equal("space-evenly", SpaceEvenly.ToString());
            Assert.Equal(typeof(ContentDistributionKeyword), SpaceEvenly.GetType());
        }
    }
}
