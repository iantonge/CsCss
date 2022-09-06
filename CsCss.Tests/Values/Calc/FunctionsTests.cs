using CsCss.Values.Angle;
using CsCss.Values.AnglePercentage;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;
using CsCss.Values.Time;
using CsCss.Values.TimePercentage;
using Xunit;

namespace CsCss.Tests.Values.Calc
{
    public class FunctionsTests
    {
        [Fact]
        public void RendersAngleCalcValue()
        {
            var result = Functions.Calc(10.Deg() - 5.Deg());
            Assert.Equal("calc(10deg - 5deg)", result.ToString());
            Assert.Equal(typeof(AngleValue), result.GetType());
        }

        [Fact]
        public void RendersLengthValue()
        {
            var result = Functions.Calc(10.Px() + 5.Px());
            Assert.Equal("calc(10px + 5px)", result.ToString());
            Assert.Equal(typeof(LengthValue), result.GetType());
        }

        [Fact]
        public void RendersPercentageValue()
        {
            var result = Functions.Calc(10.Percent() - 5.Percent());
            Assert.Equal("calc(10% - 5%)", result.ToString());
            Assert.Equal(typeof(PercentageValue), result.GetType());
        }

        [Fact]
        public void RendersTimeValue()
        {
            var result = Functions.Calc(10.S() - 5.Ms());
            Assert.Equal("calc(10s - 5ms)", result.ToString());
            Assert.Equal(typeof(TimeValue), result.GetType());
        }

        [Fact]
        public void RendersAnglePercentageValue()
        {
            var result = Functions.Calc(100.Percent() - 5.Deg());
            Assert.Equal("calc(100% - 5deg)", result.ToString());
            Assert.Equal(typeof(AnglePercentageValue), result.GetType());
        }

        [Fact]
        public void RendersLengthPercentageValue()
        {
            var result = Functions.Calc(100.Percent() - 5.Px());
            Assert.Equal("calc(100% - 5px)", result.ToString());
            Assert.Equal(typeof(LengthPercentageValue), result.GetType());
        }

        [Fact]
        public void RendersTimePercentageValue()
        {
            var result = Functions.Calc(100.Percent() - 5.S());
            Assert.Equal("calc(100% - 5s)", result.ToString());
            Assert.Equal(typeof(TimePercentageValue), result.GetType());
        }
    }
}
