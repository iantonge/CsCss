using CsCss.Values.Numeric.FitContent;
using Xunit;

namespace CsCss.Tests.Values.Numeric.FitContent
{
    public class StaticsTests
    {
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
