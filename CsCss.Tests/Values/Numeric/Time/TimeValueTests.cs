using CsCss.Values.Numeric.Time;
using CsCss.Values.Numeric.TimePercentage;
using CsCss.Values.Numeric.Calc;
using Xunit;

namespace CsCss.Tests.Values.Numeric.Time
{
    public class TimeValueTests
    {
        [Fact]
        public void CanAddTimeValue()
        {
            var time1 = 5.S();
            var time2 = 1.Ms();

            var sum = time1 + time2;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("5s + 1ms", sum.ToString());
        }

        [Fact]
        public void CanAddPercentageValue()
        {
            var time = 5.S();
            var percentage = 10.Percent();

            var sum = time + percentage;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s + 10%", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfTimeValue()
        {
            var time = 5.S();
            var calcSum = 10.S() + 1.Ms();

            var sum = time + calcSum;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("5s + 10s + 1ms", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfPercentageValue()
        {
            var time = 5.S();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = time + calcSum;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s + 10% + 1%", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfTimePercentageValue()
        {
            var time = 5.S();
            var calcSum = 10.Percent() + 5.S();

            var sum = time + calcSum;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s + 10% + 5s", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfTimeValue()
        {
            var time = 5.S();
            var calcProdct = 10.S() * 3;

            var sum = time + calcProdct;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("5s + 10s * 3", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfPercentageValue()
        {
            var time = 5.S();
            var calcProdct = 10.Percent() * 3;

            var sum = time + calcProdct;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s + 10% * 3", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfTimePercentageValue()
        {
            var time = 5.S();
            var calcSum = (10.Percent() + 15.S()) * 2;

            var sum = time + calcSum;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s + (10% + 15s) * 2", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToPercentageValue()
        {
            var time = 5.S();
            var percentage = 10.Percent();

            var sum = percentage + time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("10% + 5s", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfTimeValue()
        {
            var time = 5.S();
            var calcSum = 10.S() + 1.Ms();

            var sum = calcSum + time;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("10s + 1ms + 5s", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfPercentageValue()
        {
            var time = 5.S();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = calcSum + time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("10% + 1% + 5s", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfTimePercentageValue()
        {
            var time = 5.S();
            var calcSum = 10.Percent() + 15.S();

            var sum = calcSum + time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("10% + 15s + 5s", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfTimeValue()
        {
            var time = 5.S();
            var calcProdct = 10.S() * 3;

            var sum = calcProdct + time;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("10s * 3 + 5s", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfPercentageValue()
        {
            var time = 5.S();
            var calcProdct = 10.Percent() * 3;

            var sum = calcProdct + time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("10% * 3 + 5s", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfTimePercentageValue()
        {
            var time = 5.S();
            var calcSum = (10.Percent() + 15.S()) * 2;

            var sum = calcSum + time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("(10% + 15s) * 2 + 5s", sum.ToString());
        }

        [Fact]
        public void CanSubtractTimeValue()
        {
            var time1 = 5.S();
            var time2 = 1.Ms();

            var sum = time1 - time2;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("5s - 1ms", sum.ToString());
        }

        [Fact]
        public void CanSubtractPercentageValue()
        {
            var time = 5.S();
            var percentage = 10.Percent();

            var sum = time - percentage;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s - 10%", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfTimeValue()
        {
            var time = 5.S();
            var calcSum = 10.S() + 1.Ms();

            var sum = time - calcSum;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("5s - 10s + 1ms", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfPercentageValue()
        {
            var time = 5.S();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = time - calcSum;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s - 10% + 1%", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfTimePercentageValue()
        {
            var time = 5.S();
            var calcSum = 10.Percent() + 5.S();

            var sum = time - calcSum;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s - 10% + 5s", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfTimeValue()
        {
            var time = 5.S();
            var calcProdct = 10.S() * 3;

            var sum = time - calcProdct;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("5s - 10s * 3", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfPercentageValue()
        {
            var time = 5.S();
            var calcProdct = 10.Percent() * 3;

            var sum = time - calcProdct;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s - 10% * 3", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfTimePercentageValue()
        {
            var time = 5.S();
            var calcSum = (10.Percent() + 15.S()) * 2;

            var sum = time - calcSum;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("5s - (10% + 15s) * 2", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromPercentageValue()
        {
            var time = 5.S();
            var percentage = 10.Percent();

            var sum = percentage - time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("10% - 5s", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSumOfTimeValue()
        {
            var time = 5.S();
            var calcSum = 10.S() + 1.Ms();

            var sum = calcSum - time;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("10s + 1ms - 5s", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSumOfPercentageValue()
        {
            var time = 5.S();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = calcSum - time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("10% + 1% - 5s", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSumOfTimePercentageValue()
        {
            var time = 5.S();
            var calcSum = 10.Percent() + 15.S();

            var sum = calcSum - time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("10% + 15s - 5s", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProductOfTimeValue()
        {
            var time = 5.S();
            var calcProdct = 10.S() * 3;

            var sum = calcProdct - time;

            Assert.Equal(typeof(CalcSum<TimeValue>), sum.GetType());
            Assert.Equal("10s * 3 - 5s", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProductOfPercentageValue()
        {
            var time = 5.S();
            var calcProdct = 10.Percent() * 3;

            var sum = calcProdct - time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("10% * 3 - 5s", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProductOfTimePercentageValue()
        {
            var time = 5.S();
            var calcSum = (10.Percent() + 15.S()) * 2;

            var sum = calcSum - time;

            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
            Assert.Equal("(10% + 15s) * 2 - 5s", sum.ToString());
        }


        [Fact]
        public void CanMultiplyByInt()
        {
            var time = 5.S();

            var product = 2 * time;

            Assert.Equal(typeof(CalcProduct<TimeValue>), product.GetType());
            Assert.Equal("2 * 5s", product.ToString());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var time = 5.S();

            var product = 2.5 * time;

            Assert.Equal(typeof(CalcProduct<TimeValue>), product.GetType());
            Assert.Equal("2.5 * 5s", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var time = 5.S();

            var product = time * 2;

            Assert.Equal(typeof(CalcProduct<TimeValue>), product.GetType());
            Assert.Equal("5s * 2", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var time = 5.S();

            var product = time * 2.5;

            Assert.Equal(typeof(CalcProduct<TimeValue>), product.GetType());
            Assert.Equal("5s * 2.5", product.ToString());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var time = 5.S();

            var product = time / 2;

            Assert.Equal(typeof(CalcProduct<TimeValue>), product.GetType());
            Assert.Equal("5s / 2", product.ToString());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var time = 5.S();

            var product = time / 2.5;

            Assert.Equal(typeof(CalcProduct<TimeValue>), product.GetType());
            Assert.Equal("5s / 2.5", product.ToString());
        }
    }
}
