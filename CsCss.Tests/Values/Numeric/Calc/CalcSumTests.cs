using Xunit;

namespace CsCss.Tests.Values.Numeric.Calc
{
    public class CalcSumTests
    {
        [Fact]
        public void CanAddCalcProduct()
        {
            var calcSum = 5.Px() + 5.Cm();
            var calcProduct = 10.Px() * 10;
            var product = calcSum + calcProduct;
            Assert.Equal("5px + 5cm + 10px * 10", product.ToString());
        }

        [Fact]
        public void CanAddCalcSum()
        {
            var calcSum1 = 5.Px() + 10.Px();
            var calcSum2 = 5.Cm() + 10.Cm();
            var sum = calcSum1 + calcSum2;
            Assert.Equal("5px + 10px + 5cm + 10cm", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProduct()
        {
            var calcSum = 5.Px() + 5.Cm();
            var calcProduct = 10.Px() * 10;
            var product = calcSum - calcProduct;
            Assert.Equal("5px + 5cm - 10px * 10", product.ToString());
        }

        [Fact]
        public void CanSubtractCalcSum()
        {
            var calcSum1 = 5.Px() + 5.Cm();
            var calcSum2 = 10.Px() + 10.Cm();
            var sum = calcSum1 - calcSum2;
            Assert.Equal("5px + 5cm - 10px + 10cm", sum.ToString());
        }

        [Fact]
        public void CanMultiplyByInt()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = 2 * calcSum;
            Assert.Equal("2 * (5px + 5cm)", product.ToString());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = 2.5 * calcSum;
            Assert.Equal("2.5 * (5px + 5cm)", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = calcSum * 2;
            Assert.Equal("(5px + 5cm) * 2", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = calcSum * 2.5;
            Assert.Equal("(5px + 5cm) * 2.5", product.ToString());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = calcSum / 2;
            Assert.Equal("(5px + 5cm) / 2", product.ToString());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var calcSum = 5.Px() + 5.Cm();
            var product = calcSum / 2.5;
            Assert.Equal("(5px + 5cm) / 2.5", product.ToString());
        }
    }
}
