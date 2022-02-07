using Xunit;

namespace CsCss.Tests.Values.Numeric.Calc
{
    public class StaticsTests
    {
        [Fact]
        public void RendersAngleCalcValue()
        {
            var result = Statics.Calc(10.Deg() - 5.Deg());
            Assert.Equal("calc(10deg - 5deg)", result.ToString());
        }

        [Fact]
        public void RendersLengthValue()
        {
            var result = Statics.Calc(10.Px() + 5.Px());
            Assert.Equal("calc(10px + 5px)", result.ToString());
        }

        [Fact]
        public void RendersPercentageValue()
        {
            var result = Statics.Calc(10.Percent() - 5.Percent());
            Assert.Equal("calc(10% - 5%)", result.ToString());
        }

        [Fact]
        public void RendersTimeValue()
        {
            var result = Statics.Calc(10.S() - 5.Ms());
            Assert.Equal("calc(10s - 5ms)", result.ToString());
        }

        [Fact]
        public void RendersAnglePercentageValue()
        {
            var result = Statics.Calc(100.Percent() - 5.Deg());
            Assert.Equal("calc(100% - 5deg)", result.ToString());
        }

        [Fact]
        public void RendersLengthPercentageValue()
        {
            var result = Statics.Calc(100.Percent() - 5.Px());
            Assert.Equal("calc(100% - 5px)", result.ToString());
        }

        [Fact]
        public void RendersTimePercentageValue()
        {
            var result = Statics.Calc(100.Percent() - 5.S());
            Assert.Equal("calc(100% - 5s)", result.ToString());
        }
    }
}
