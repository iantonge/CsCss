using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CsCss.Tests.Values.Numeric.Calc
{
    public class CalcProductTests
    {
        [Fact]
        public void CanAddCalcSum()
        {
            var calcProduct = 5.Px() * 5;
            var calcSum = 5.Px() + 5.Px();
            var sum = calcProduct + calcSum;
            Assert.Equal("5px * 5 + 5px + 5px", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProduct()
        {
            var calcProduct1 = 5.Px() * 5;
            var calcProduct2 = 10.Px() * 10;
            var product = calcProduct1 + calcProduct2;
            Assert.Equal("5px * 5 + 10px * 10", product.ToString());
        }

        [Fact]
        public void CanSubtractCalcSum()
        {
            var calcProduct = 5.Px() * 5;
            var calcSum = 5.Px() + 5.Px();
            var sum = calcProduct - calcSum;
            Assert.Equal("5px * 5 - 5px + 5px", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProduct()
        {
            var calcProduct1 = 5.Px() * 5;
            var calcProduct2 = 10.Px() * 10;
            var product = calcProduct1 - calcProduct2;
            Assert.Equal("5px * 5 - 10px * 10", product.ToString());
        }

        [Fact]
        public void CanMultiplyByInt()
        {
            var calcProduct = 5.Px() * 5;
            var product = 2 * calcProduct;
            Assert.Equal("2 * 5px * 5", product.ToString());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var calcProduct = 5.Px() * 5;
            var product = 2.5 * calcProduct;
            Assert.Equal("2.5 * 5px * 5", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var calcProduct = 5.Px() * 5;
            var product = calcProduct * 2;
            Assert.Equal("5px * 5 * 2", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var calcProduct = 5.Px() * 5;
            var product = calcProduct * 2.5;
            Assert.Equal("5px * 5 * 2.5", product.ToString());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var calcProduct = 5.Px() * 5;
            var product = calcProduct / 2;
            Assert.Equal("5px * 5 / 2", product.ToString());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var calcProduct = 5.Px() * 5;
            var product = calcProduct / 2.5;
            Assert.Equal("5px * 5 / 2.5", product.ToString());
        }
    }
}
