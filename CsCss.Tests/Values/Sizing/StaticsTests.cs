using CsCss.Values.Sizing;
using Xunit;

namespace CsCss.Tests.Values.Sizing
{
    public class StaticsTests
    {
        [Fact]
        public void RendersContainKeyword()
        {
            Assert.Equal("contain", Statics.Contain.ToString());
            Assert.Equal(typeof(ContainKeyword), Statics.Contain.GetType());
        }

        [Fact]
        public void RendersCoverKeyword()
        {
            Assert.Equal("cover", Statics.Cover.ToString());
            Assert.Equal(typeof(CoverKeyword), Statics.Cover.GetType());
        }

        [Fact]
        public void RendersFitContentKeyword()
        {
            Assert.Equal("fit-content", Statics.FitContent().ToString());
            Assert.Equal(typeof(FitContentKeyword), Statics.FitContent().GetType());
        }

        [Fact]
        public void RendersMaxContentKeyword()
        {
            Assert.Equal("max-content", Statics.MaxContent.ToString());
            Assert.Equal(typeof(MaxContentKeyword), Statics.MaxContent.GetType());
        }

        [Fact]
        public void RendersMinContentKeyword()
        {
            Assert.Equal("min-content", Statics.MinContent.ToString());
            Assert.Equal(typeof(MinContentKeyword), Statics.MinContent.GetType());
        }

        [Fact]
        public void RendersAngleFitContentValue()
        {
            var result = Statics.FitContent(10.Deg());
            Assert.Equal("fit-content(10deg)", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }

        [Fact]
        public void RendersPercentageFitContentValue()
        {
            var result = Statics.FitContent(10.Percent());
            Assert.Equal("fit-content(10%)", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }

        [Fact]
        public void RendersAnglePercentageFitContentValue()
        {
            var result = Statics.FitContent(Statics.Calc(10.Percent() - 10.Deg()));
            Assert.Equal("fit-content(calc(10% - 10deg))", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }
    }
}
