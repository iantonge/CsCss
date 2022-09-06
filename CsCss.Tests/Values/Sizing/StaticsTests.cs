using CsCss.Values.Sizing;
using Xunit;

namespace CsCss.Tests.Values.Sizing
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersContainKeyword()
        {
            Assert.Equal("contain", Keywords.Contain.ToString());
            Assert.Equal(typeof(ContainKeyword), Keywords.Contain.GetType());
        }

        [Fact]
        public void RendersCoverKeyword()
        {
            Assert.Equal("cover", Keywords.Cover.ToString());
            Assert.Equal(typeof(CoverKeyword), Keywords.Cover.GetType());
        }

        [Fact]
        public void RendersFitContentKeyword()
        {
            Assert.Equal("fit-content", Keywords.FitContent.ToString());
            Assert.Equal(typeof(FitContentKeyword), Keywords.FitContent.GetType());
        }

        [Fact]
        public void RendersMaxContentKeyword()
        {
            Assert.Equal("max-content", Keywords.MaxContent.ToString());
            Assert.Equal(typeof(MaxContentKeyword), Keywords.MaxContent.GetType());
        }

        [Fact]
        public void RendersMinContentKeyword()
        {
            Assert.Equal("min-content", Keywords.MinContent.ToString());
            Assert.Equal(typeof(MinContentKeyword), Keywords.MinContent.GetType());
        }

        [Fact]
        public void RendersAngleFitContentValue()
        {
            var result = Functions.FitContent(10.Deg());
            Assert.Equal("fit-content(10deg)", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }

        [Fact]
        public void RendersPercentageFitContentValue()
        {
            var result = Functions.FitContent(10.Percent());
            Assert.Equal("fit-content(10%)", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }

        [Fact]
        public void RendersAnglePercentageFitContentValue()
        {
            var result = Functions.FitContent(Functions.Calc(10.Percent() - 10.Deg()));
            Assert.Equal("fit-content(calc(10% - 10deg))", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }
    }
}
