using CsCss.Values.Numeric.Angle;
using CsCss.Values.Numeric.AnglePercentage;
using CsCss.Values.Numeric.Length;
using CsCss.Values.Numeric.LengthPercentage;
using CsCss.Values.Numeric.Percentage;
using CsCss.Values.Numeric.Time;
using CsCss.Values.Numeric.TimePercentage;
using Xunit;

namespace CsCss.Tests.Values.Numeric.Calc
{
    public class Statics
    {
        [Fact]
        public void RendersAngleCalcValue()
        {
            var result = CsCss.Statics.Calc(10.Deg() - 5.Deg());
            Assert.Equal("calc(10deg - 5deg)", result.ToString());
            Assert.Equal(typeof(AngleValue), result.GetType());
        }

        [Fact]
        public void RendersLengthValue()
        {
            var result = CsCss.Statics.Calc(10.Px() + 5.Px());
            Assert.Equal("calc(10px + 5px)", result.ToString());
            Assert.Equal(typeof(LengthValue), result.GetType());
        }

        [Fact]
        public void RendersPercentageValue()
        {
            var result = CsCss.Statics.Calc(10.Percent() - 5.Percent());
            Assert.Equal("calc(10% - 5%)", result.ToString());
            Assert.Equal(typeof(PercentageValue), result.GetType());
        }

        [Fact]
        public void RendersTimeValue()
        {
            var result = CsCss.Statics.Calc(10.S() - 5.Ms());
            Assert.Equal("calc(10s - 5ms)", result.ToString());
            Assert.Equal(typeof(TimeValue), result.GetType());
        }

        [Fact]
        public void RendersAnglePercentageValue()
        {
            var result = CsCss.Statics.Calc(100.Percent() - 5.Deg());
            Assert.Equal("calc(100% - 5deg)", result.ToString());
            Assert.Equal(typeof(AnglePercentageValue), result.GetType());
        }

        [Fact]
        public void RendersLengthPercentageValue()
        {
            var result = CsCss.Statics.Calc(100.Percent() - 5.Px());
            Assert.Equal("calc(100% - 5px)", result.ToString());
            Assert.Equal(typeof(LengthPercentageValue), result.GetType());
        }

        [Fact]
        public void RendersTimePercentageValue()
        {
            var result = CsCss.Statics.Calc(100.Percent() - 5.S());
            Assert.Equal("calc(100% - 5s)", result.ToString());
            Assert.Equal(typeof(TimePercentageValue), result.GetType());
        }
    }
}
