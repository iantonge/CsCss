using CsCss.Values.Calc;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;
using Xunit;

namespace CsCss.Tests.Values.LengthPercentage
{
    public class LengthPercentageValueTests
    {
        [Fact]
        public void CanConvertFromLengthValue()
        {
            var length = 2.5.Cm();
            Assert.Equal(typeof(LengthValue), length.GetType());
            LengthPercentageValue converted = length;
            Assert.Equal("2.5cm", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPercentageValue()
        {
            var percentage = 2.5.Percent();
            Assert.Equal(typeof(PercentageValue), percentage.GetType());
            LengthPercentageValue converted = percentage;
            Assert.Equal("2.5%", converted.ToString());
        }

        [Fact]
        public void CanAddLengthPercentage()
        {
            var lengthPercentage1 = Functions.Calc(5.Percent() + 5.Cm());
            var lengthPercentage2 = Functions.Calc(10.Percent() + 10.Cm());
            var sum = lengthPercentage1 + lengthPercentage2;
            Assert.Equal("calc(5% + 5cm) + calc(10% + 10cm)", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanAddCalcSum()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var calcSum = 10.Percent() + 10.Cm();
            var sum = lengthPercentage + calcSum;
            Assert.Equal("calc(5% + 5cm) + 10% + 10cm", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanAddCalcProduct()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var calcProduct = (10.Percent() + 5.Cm()) * 10;
            var sum = lengthPercentage + calcProduct;
            Assert.Equal("calc(5% + 5cm) + (10% + 5cm) * 10", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeAdddedToCalcSum()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var calcSum = 10.Percent() + 10.Cm();
            var sum = calcSum + lengthPercentage;
            Assert.Equal("10% + 10cm + calc(5% + 5cm)", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeAddedToCalcProduct()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var calcProduct = (10.Percent() + 5.Cm()) * 10;
            var sum = calcProduct + lengthPercentage;
            Assert.Equal("(10% + 5cm) * 10 + calc(5% + 5cm)", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractLengthPercentage()
        {
            var lengthPercentage1 = Functions.Calc(5.Percent() + 5.Cm());
            var lengthPercentage2 = Functions.Calc(10.Percent() + 10.Cm());
            var sum = lengthPercentage1 - lengthPercentage2;
            Assert.Equal("calc(5% + 5cm) - calc(10% + 10cm)", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractCalcSum()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var calcSum = 10.Percent() + 10.Cm();
            var sum = lengthPercentage - calcSum;
            Assert.Equal("calc(5% + 5cm) - 10% + 10cm", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractCalcProduct()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var calcProduct = (10.Percent() + 5.Cm()) * 10;
            var sum = lengthPercentage - calcProduct;
            Assert.Equal("calc(5% + 5cm) - (10% + 5cm) * 10", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSum()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var calcSum = 10.Percent() + 10.Cm();
            var sum = calcSum - lengthPercentage;
            Assert.Equal("10% + 10cm - calc(5% + 5cm)", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProduct()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var calcProduct = (10.Percent() + 5.Cm()) * 10;
            var sum = calcProduct - lengthPercentage;
            Assert.Equal("(10% + 5cm) * 10 - calc(5% + 5cm)", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanMultiplyByInt()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var product = 2 * lengthPercentage;
            Assert.Equal("2 * calc(5% + 5cm)", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthPercentageValue>), product.GetType());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var product = 2.5 * lengthPercentage;
            Assert.Equal("2.5 * calc(5% + 5cm)", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthPercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var product = lengthPercentage * 2;
            Assert.Equal("calc(5% + 5cm) * 2", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthPercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var product = lengthPercentage * 2.5;
            Assert.Equal("calc(5% + 5cm) * 2.5", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthPercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var product = lengthPercentage / 2;
            Assert.Equal("calc(5% + 5cm) / 2", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthPercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var lengthPercentage = Functions.Calc(5.Percent() + 5.Cm());
            var product = lengthPercentage / 2.5;
            Assert.Equal("calc(5% + 5cm) / 2.5", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthPercentageValue>), product.GetType());
        }
    }
}
