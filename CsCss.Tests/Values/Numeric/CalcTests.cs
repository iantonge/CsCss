using Xunit;
using static CsCss.Statics;

namespace CsCss.Tests.Values.Numeric
{
    public class CalcTests
    {
        [Fact]
        public void RendersLengthSubtraction()
        {
            var result = Calc(100.Percent() - 5.Px());
            Assert.Equal("calc(100% - 5px)", result.ToString());
        }

        [Fact]
        public void RendersLengthAddition()
        {
            var result = Calc(100.Percent() + 5.Px());
            Assert.Equal("calc(100% + 5px)", result.ToString());
        }

        [Fact]
        public void RendersLengthMultiplication()
        {
            var result = Calc(10.Percent() * 5);
            Assert.Equal("calc(10% * 5)", result.ToString());
        }

        [Fact]
        public void RendersLengthDivision()
        {
            var result = Calc(100.Percent() / 5);
            Assert.Equal("calc(100% / 5)", result.ToString());
        }

        [Fact]
        public void RendersComplexCalculation()
        {
            var result = Calc(100.Percent() - 5.Px() / 5);
            Assert.Equal("calc(100% - 5px / 5)", result.ToString());
        }

        [Fact]
        public void RendersComplexCalculationWithBrackets()
        {
            var result = Calc((100.Percent() - 5.Px()) / 5);
            Assert.Equal("calc((100% - 5px) / 5)", result.ToString());
        }
    }
}
