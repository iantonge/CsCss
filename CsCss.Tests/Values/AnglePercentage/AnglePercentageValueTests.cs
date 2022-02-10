using CsCss.Values.Angle;
using CsCss.Values.AnglePercentage;
using CsCss.Values.Calc;
using CsCss.Values.Percentage;
using Xunit;

namespace CsCss.Tests.Values.AnglePercentage
{
    public class AnglePercentageValueTests
    {
        [Fact]
        public void CanConvertFromAngleValue()
        {
            var angle = 2.5.Deg();
            Assert.Equal(typeof(AngleValue), angle.GetType());
            AnglePercentageValue converted = angle;
            Assert.Equal("2.5deg", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPercentageValue()
        {
            var percentage = 2.5.Percent();
            Assert.Equal(typeof(PercentageValue), percentage.GetType());
            AnglePercentageValue converted = percentage;
            Assert.Equal("2.5%", converted.ToString());
        }

        [Fact]
        public void CanAddAnglePercentage()
        {
            var anglePercentage1 = Statics.Calc(5.Percent() + 5.Deg());
            var anglePercentage2 = Statics.Calc(10.Percent() + 10.Deg());
            var sum = anglePercentage1 + anglePercentage2;
            Assert.Equal("calc(5% + 5deg) + calc(10% + 10deg)", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanAddCalcSum()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var calcSum = 10.Percent() + 10.Deg();
            var sum = anglePercentage + calcSum;
            Assert.Equal("calc(5% + 5deg) + 10% + 10deg", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanAddCalcProduct()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var calcProduct = (10.Percent() + 5.Deg()) * 10;
            var sum = anglePercentage + calcProduct;
            Assert.Equal("calc(5% + 5deg) + (10% + 5deg) * 10", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeAddedToCalcSum()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var calcSum = 10.Percent() + 10.Deg();
            var sum = calcSum + anglePercentage;
            Assert.Equal("10% + 10deg + calc(5% + 5deg)", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeAddedToCalcProduct()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var calcProduct = (10.Percent() + 5.Deg()) * 10;
            var sum = calcProduct + anglePercentage;
            Assert.Equal("(10% + 5deg) * 10 + calc(5% + 5deg)", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractAnglePercentage()
        {
            var anglePercentage1 = Statics.Calc(5.Percent() + 5.Deg());
            var anglePercentage2 = Statics.Calc(10.Percent() + 10.Deg());
            var sum = anglePercentage1 - anglePercentage2;
            Assert.Equal("calc(5% + 5deg) - calc(10% + 10deg)", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractCalcSum()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var calcSum = 10.Percent() + 10.Deg();
            var sum = anglePercentage - calcSum;
            Assert.Equal("calc(5% + 5deg) - 10% + 10deg", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanSubtractCalcProduct()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var calcProduct = (10.Percent() + 5.Deg()) * 10;
            var sum = anglePercentage - calcProduct;
            Assert.Equal("calc(5% + 5deg) - (10% + 5deg) * 10", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeSubtractedFromCalcSum()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var calcSum = 10.Percent() + 10.Deg();
            var sum = calcSum - anglePercentage;
            Assert.Equal("10% + 10deg - calc(5% + 5deg)", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanBeSubtractedFromCalcProduct()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var calcProduct = (10.Percent() + 5.Deg()) * 10;
            var sum = calcProduct - anglePercentage;
            Assert.Equal("(10% + 5deg) * 10 - calc(5% + 5deg)", sum.ToString());
            Assert.Equal(typeof(CalcSum<AnglePercentageValue>), sum.GetType());
        }

        [Fact]
        public void CanMultiplyByInt()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var product = 2 * anglePercentage;
            Assert.Equal("2 * calc(5% + 5deg)", product.ToString());
            Assert.Equal(typeof(CalcProduct<AnglePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var product = 2.5 * anglePercentage;
            Assert.Equal("2.5 * calc(5% + 5deg)", product.ToString());
            Assert.Equal(typeof(CalcProduct<AnglePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var product = anglePercentage * 2;
            Assert.Equal("calc(5% + 5deg) * 2", product.ToString());
            Assert.Equal(typeof(CalcProduct<AnglePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var product = anglePercentage * 2.5;
            Assert.Equal("calc(5% + 5deg) * 2.5", product.ToString());
            Assert.Equal(typeof(CalcProduct<AnglePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var product = anglePercentage / 2;
            Assert.Equal("calc(5% + 5deg) / 2", product.ToString());
            Assert.Equal(typeof(CalcProduct<AnglePercentageValue>), product.GetType());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var anglePercentage = Statics.Calc(5.Percent() + 5.Deg());
            var product = anglePercentage / 2.5;
            Assert.Equal("calc(5% + 5deg) / 2.5", product.ToString());
            Assert.Equal(typeof(CalcProduct<AnglePercentageValue>), product.GetType());
        }
    }
}
