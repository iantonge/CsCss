using CsCss.Values.Calc;
using CsCss.Values.Length;
using Xunit;

namespace CsCss.Tests.Values.Calc
{
    public class CalcSumTests
    {
        [Fact]
        public void CanAddCalcProduct()
        {
            var calcSum = 5.Px() + 5.Cm();
            var calcProduct = 10.Px() * 10;
            var sum = calcSum + calcProduct;
            Assert.Equal("5px + 5cm + 10px * 10", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
        }

        [Fact]
        public void CanAddCalcSum()
        {
            var calcSum1 = 5.Px() + 10.Px();
            var calcSum2 = 5.Cm() + 10.Cm();
            var sum = calcSum1 + calcSum2;
            Assert.Equal("5px + 10px + 5cm + 10cm", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
        }

        [Fact]
        public void CanBeAddedToCalcProduct()
        {
            var calcSum = 5.Px() + 5.Cm();
            var calcProduct = 10.Px() * 10;
            var sum = calcProduct + calcSum;
            Assert.Equal("10px * 10 + 5px + 5cm", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractCalcProduct()
        {
            var calcSum = 5.Px() + 5.Cm();
            var calcProduct = 10.Px() * 10;
            var sum = calcSum - calcProduct;
            Assert.Equal("5px + 5cm - 10px * 10", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractCalcSum()
        {
            var calcSum1 = 5.Px() + 5.Cm();
            var calcSum2 = 10.Px() + 10.Cm();
            var sum = calcSum1 - calcSum2;
            Assert.Equal("5px + 5cm - 10px + 10cm", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProduct()
        {
            var calcSum = 5.Px() + 5.Cm();
            var calcProduct = 10.Px() * 10;
            var sum = calcProduct - calcSum;
            Assert.Equal("10px * 10 - 5px + 5cm", sum.ToString());
            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
        }

        [Fact]
        public void CanMultiplyByInt()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = 2 * calcSum;
            Assert.Equal("2 * (5px + 5cm)", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = 2.5 * calcSum;
            Assert.Equal("2.5 * (5px + 5cm)", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = calcSum * 2;
            Assert.Equal("(5px + 5cm) * 2", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = calcSum * 2.5;
            Assert.Equal("(5px + 5cm) * 2.5", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = calcSum / 2;
            Assert.Equal("(5px + 5cm) / 2", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = calcSum / 2.5;
            Assert.Equal("(5px + 5cm) / 2.5", product.ToString());
            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
        }
    }
}
