using CsCss.Values.Percentage;
using CsCss.Values.Calc;
using Xunit;

namespace CsCss.Tests.Values.Percentage
{
    public class PercentageValueTests
    {
        [Fact]
        public void CanAddPercentageValue()
        {
            var percentage1 = 5.Percent();
            var percentage2 = 1.Percent();

            var sum = percentage1 + percentage2;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("5% + 1%", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfPercentageValue()
        {
            var percentage = 5.Percent();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = percentage + calcSum;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("5% + 10% + 1%", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfPercentageValue()
        {
            var percentage = 5.Percent();
            var calcProdct = 10.Percent() * 3;

            var sum = percentage + calcProdct;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("5% + 10% * 3", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfPercentageValue()
        {
            var percentage = 5.Percent();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = calcSum + percentage;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("10% + 1% + 5%", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfPercentageValue()
        {
            var percentage = 5.Percent();
            var calcProdct = 10.Percent() * 3;

            var sum = calcProdct + percentage;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("10% * 3 + 5%", sum.ToString());
        }

        [Fact]
        public void CanSubtractPercentageValue()
        {
            var percentage1 = 5.Percent();
            var percentage2 = 1.Percent();

            var sum = percentage1 - percentage2;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("5% - 1%", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfPercentageValue()
        {
            var percentage = 5.Percent();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = percentage - calcSum;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("5% - 10% + 1%", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfPercentageValue()
        {
            var percentage = 5.Percent();
            var calcProdct = 10.Percent() * 3;

            var sum = percentage - calcProdct;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("5% - 10% * 3", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSumOfPercentageValue()
        {
            var percentage = 5.Percent();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = calcSum - percentage;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("10% + 1% - 5%", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProductOfPercentageValue()
        {
            var percentage = 5.Percent();
            var calcProdct = 10.Percent() * 3;

            var sum = calcProdct - percentage;

            Assert.Equal(typeof(CalcSum<PercentageValue>), sum.GetType());
            Assert.Equal("10% * 3 - 5%", sum.ToString());
        }

        [Fact]
        public void CanMultiplyByInt()
        {
            var percentage = 5.Percent();

            var product = 2 * percentage;

            Assert.Equal(typeof(CalcProduct<PercentageValue>), product.GetType());
            Assert.Equal("2 * 5%", product.ToString());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var percentage = 5.Percent();

            var product = 2.5 * percentage;

            Assert.Equal(typeof(CalcProduct<PercentageValue>), product.GetType());
            Assert.Equal("2.5 * 5%", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var percentage = 5.Percent();

            var product = percentage * 2;

            Assert.Equal(typeof(CalcProduct<PercentageValue>), product.GetType());
            Assert.Equal("5% * 2", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var percentage = 5.Percent();

            var product = percentage * 2.5;

            Assert.Equal(typeof(CalcProduct<PercentageValue>), product.GetType());
            Assert.Equal("5% * 2.5", product.ToString());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var percentage = 5.Percent();

            var product = percentage / 2;

            Assert.Equal(typeof(CalcProduct<PercentageValue>), product.GetType());
            Assert.Equal("5% / 2", product.ToString());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var percentage = 5.Percent();

            var product = percentage / 2.5;

            Assert.Equal(typeof(CalcProduct<PercentageValue>), product.GetType());
            Assert.Equal("5% / 2.5", product.ToString());
        }
    }
}
