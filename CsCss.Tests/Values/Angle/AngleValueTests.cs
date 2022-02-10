using CsCss.Values.Angle;
using CsCss.Values.AnglePercentage;
using CsCss.Values.Calc;
using Xunit;

namespace CsCss.Tests.Values.Angle
{
    public class AngleValueTests
    {
        [Fact]
        public void CanAddAngleValue()
        {
            var angle1 = 5.Deg();
            var angle2 = 1.Rad();

            var sum = angle1 + angle2;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("5deg + 1rad", sum.ToString());
        }

        [Fact]
        public void CanAddPercentageValue()
        {
            var angle = 5.Deg();
            var percentage = 10.Percent();

            var sum = angle + percentage;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg + 10%", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfAngleValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Deg() + 1.Rad();

            var sum = angle + calcSum;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("5deg + 10deg + 1rad", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfPercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = angle + calcSum;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg + 10% + 1%", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfAnglePercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Percent() + 5.Deg();

            var sum = angle + calcSum;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg + 10% + 5deg", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfAngleValue()
        {
            var angle = 5.Deg();
            var calcProdct = 10.Deg() * 3;

            var sum = angle + calcProdct;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("5deg + 10deg * 3", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfPercentageValue()
        {
            var angle = 5.Deg();
            var calcProdct = 10.Percent() * 3;

            var sum = angle + calcProdct;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg + 10% * 3", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfAnglePercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = (10.Percent() + 15.Deg()) * 2;

            var sum = angle + calcSum;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg + (10% + 15deg) * 2", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToPercentageValue()
        {
            var angle = 5.Deg();
            var percentage = 10.Percent();

            var sum = percentage + angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("10% + 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfAngleValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Deg() + 1.Rad();

            var sum = calcSum + angle;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("10deg + 1rad + 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfPercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = calcSum + angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("10% + 1% + 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfAnglePercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Percent() + 15.Deg();

            var sum = calcSum + angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("10% + 15deg + 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfAngleValue()
        {
            var angle = 5.Deg();
            var calcProdct = 10.Deg() * 3;

            var sum = calcProdct + angle;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("10deg * 3 + 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfPercentageValue()
        {
            var angle = 5.Deg();
            var calcProdct = 10.Percent() * 3;

            var sum = calcProdct + angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("10% * 3 + 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfAnglePercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = (10.Percent() + 15.Deg()) * 2;

            var sum = calcSum + angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("(10% + 15deg) * 2 + 5deg", sum.ToString());
        }

        [Fact]
        public void CanSubtractAngleValue()
        {
            var angle1 = 5.Deg();
            var angle2 = 1.Rad();

            var sum = angle1 - angle2;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("5deg - 1rad", sum.ToString());
        }

        [Fact]
        public void CanSubtractPercentageValue()
        {
            var angle = 5.Deg();
            var percentage = 10.Percent();

            var sum = angle - percentage;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg - 10%", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfAngleValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Deg() + 1.Rad();

            var sum = angle - calcSum;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("5deg - 10deg + 1rad", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfPercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = angle - calcSum;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg - 10% + 1%", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfAnglePercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Percent() + 5.Deg();

            var sum = angle - calcSum;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg - 10% + 5deg", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfAngleValue()
        {
            var angle = 5.Deg();
            var calcProdct = 10.Deg() * 3;

            var sum = angle - calcProdct;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("5deg - 10deg * 3", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfPercentageValue()
        {
            var angle = 5.Deg();
            var calcProdct = 10.Percent() * 3;

            var sum = angle - calcProdct;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg - 10% * 3", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfAnglePercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = (10.Percent() + 15.Deg()) * 2;

            var sum = angle - calcSum;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("5deg - (10% + 15deg) * 2", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromPercentageValue()
        {
            var angle = 5.Deg();
            var percentage = 10.Percent();

            var sum = percentage - angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("10% - 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSumOfAngleValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Deg() + 1.Rad();

            var sum = calcSum - angle;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("10deg + 1rad - 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSumOfPercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = calcSum - angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("10% + 1% - 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSumOfAnglePercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = 10.Percent() + 15.Deg();

            var sum = calcSum - angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("10% + 15deg - 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProductOfAngleValue()
        {
            var angle = 5.Deg();
            var calcProdct = 10.Deg() * 3;

            var sum = calcProdct - angle;

            Assert.Equal(typeof(CalcSum<AngleValue>), sum.GetType());
            Assert.Equal("10deg * 3 - 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProductOfPercentageValue()
        {
            var angle = 5.Deg();
            var calcProdct = 10.Percent() * 3;

            var sum = calcProdct - angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("10% * 3 - 5deg", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProductOfAnglePercentageValue()
        {
            var angle = 5.Deg();
            var calcSum = (10.Percent() + 15.Deg()) * 2;

            var sum = calcSum - angle;

            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
            Assert.Equal("(10% + 15deg) * 2 - 5deg", sum.ToString());
        }


        [Fact]
        public void CanMultiplyByInt()
        {
            var angle = 5.Deg();

            var product = 2 * angle;

            Assert.Equal(typeof(CalcProduct<AngleValue>), product.GetType());
            Assert.Equal("2 * 5deg", product.ToString());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var angle = 5.Deg();

            var product = 2.5 * angle;

            Assert.Equal(typeof(CalcProduct<AngleValue>), product.GetType());
            Assert.Equal("2.5 * 5deg", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var angle = 5.Deg();

            var product = angle * 2;

            Assert.Equal(typeof(CalcProduct<AngleValue>), product.GetType());
            Assert.Equal("5deg * 2", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var angle = 5.Deg();

            var product = angle * 2.5;

            Assert.Equal(typeof(CalcProduct<AngleValue>), product.GetType());
            Assert.Equal("5deg * 2.5", product.ToString());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var angle = 5.Deg();

            var product = angle / 2;

            Assert.Equal(typeof(CalcProduct<AngleValue>), product.GetType());
            Assert.Equal("5deg / 2", product.ToString());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var angle = 5.Deg();

            var product = angle / 2.5;

            Assert.Equal(typeof(CalcProduct<AngleValue>), product.GetType());
            Assert.Equal("5deg / 2.5", product.ToString());
        }
    }
}
