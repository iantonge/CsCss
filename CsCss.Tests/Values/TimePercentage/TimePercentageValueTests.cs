using CsCss.Values.Calc;
using CsCss.Values.Time;
using CsCss.Values.TimePercentage;
using CsCss.Values.Percentage;
using Xunit;

namespace CsCss.Tests.Values.TimePercentage
{
    public class TimePercentageValueTests
    {
        [Fact]
        public void CanConvertFromTimeValue()
        {
            var length = 2.5.S();
            Assert.Equal(typeof(TimeValue), length.GetType());
            TimePercentageValue converted = length;
            Assert.Equal("2.5s", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPercentageValue()
        {
            var percentage = 2.5.Percent();
            Assert.Equal(typeof(PercentageValue), percentage.GetType());
            TimePercentageValue converted = percentage;
            Assert.Equal("2.5%", converted.ToString());
        }

        [Fact]
        public void CanAddTimePercentage()
        {
            var lengthPercentage1 = Functions.Calc(5.Percent() + 5.S());
            var lengthPercentage2 = Functions.Calc(10.Percent() + 10.S());
            var sum = lengthPercentage1 + lengthPercentage2;
            Assert.Equal("calc(5% + 5s) + calc(10% + 10s)", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanAddCalcSum()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var calcSum = 10.Percent() + 10.S();
            var sum = lengthPercentage + calcSum;
            Assert.Equal("calc(5% + 5s) + 10% + 10s", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanAddCalcProduct()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var calcProduct = (10.Percent() + 5.S()) * 10;
            var sum = lengthPercentage + calcProduct;
            Assert.Equal("calc(5% + 5s) + (10% + 5s) * 10", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeAdddedToCalcSum()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var calcSum = 10.Percent() + 10.S();
            var sum = calcSum + lengthPercentage;
            Assert.Equal("10% + 10s + calc(5% + 5s)", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeAddedToCalcProduct()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var calcProduct = (10.Percent() + 5.S()) * 10;
            var sum = calcProduct + lengthPercentage;
            Assert.Equal("(10% + 5s) * 10 + calc(5% + 5s)", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractTimePercentage()
        {
            var lengthPercentage1 = Functions.Calc(5.Percent() + 5.S());
            var lengthPercentage2 = Functions.Calc(10.Percent() + 10.S());
            var sum = lengthPercentage1 - lengthPercentage2;
            Assert.Equal("calc(5% + 5s) - calc(10% + 10s)", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractCalcSum()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var calcSum = 10.Percent() + 10.S();
            var sum = lengthPercentage - calcSum;
            Assert.Equal("calc(5% + 5s) - 10% + 10s", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractCalcProduct()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var calcProduct = (10.Percent() + 5.S()) * 10;
            var sum = lengthPercentage - calcProduct;
            Assert.Equal("calc(5% + 5s) - (10% + 5s) * 10", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSum()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var calcSum = 10.Percent() + 10.S();
            var sum = calcSum - lengthPercentage;
            Assert.Equal("10% + 10s - calc(5% + 5s)", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProduct()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var calcProduct = (10.Percent() + 5.S()) * 10;
            var sum = calcProduct - lengthPercentage;
            Assert.Equal("(10% + 5s) * 10 - calc(5% + 5s)", sum.ToString());
            Assert.Equal(typeof(CalcSum<TimePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanMultiplyByInt()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var product = 2 * lengthPercentage;
            Assert.Equal("2 * calc(5% + 5s)", product.ToString());
            Assert.Equal(typeof(CalcProduct<TimePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var product = 2.5 * lengthPercentage;
            Assert.Equal("2.5 * calc(5% + 5s)", product.ToString());
            Assert.Equal(typeof(CalcProduct<TimePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var product = lengthPercentage * 2;
            Assert.Equal("calc(5% + 5s) * 2", product.ToString());
            Assert.Equal(typeof(CalcProduct<TimePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var product = lengthPercentage * 2.5;
            Assert.Equal("calc(5% + 5s) * 2.5", product.ToString());
            Assert.Equal(typeof(CalcProduct<TimePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var product = lengthPercentage / 2;
            Assert.Equal("calc(5% + 5s) / 2", product.ToString());
            Assert.Equal(typeof(CalcProduct<TimePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.S());
            var product = lengthPercentage / 2.5;
            Assert.Equal("calc(5% + 5s) / 2.5", product.ToString());
            Assert.Equal(typeof(CalcProduct<TimePercentageValue>), product.GetType());
        }
    }
}
