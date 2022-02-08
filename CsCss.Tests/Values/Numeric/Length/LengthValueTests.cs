using CsCss.Values.Numeric.Length;
using CsCss.Values.Numeric.LengthPercentage;
using CsCss.Values.Numeric.Calc;
using Xunit;

namespace CsCss.Tests.Values.Numeric.Length
{
    public class LengthValueTests
    {
        [Fact]
        public void CanAddLengthValue()
        {
            var Length1 = 5.Px();
            var Length2 = 1.Cm();

            var sum = Length1 + Length2;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("5px + 1cm", sum.ToString());
        }

        [Fact]
        public void CanAddPercentageValue()
        {
            var Length = 5.Px();
            var percentage = 10.Percent();

            var sum = Length + percentage;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px + 10%", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfLengthValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Px() + 1.Cm();

            var sum = Length + calcSum;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("5px + 10px + 1cm", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = Length + calcSum;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px + 10% + 1%", sum.ToString());
        }

        [Fact]
        public void CanAddCalcSumOfLengthPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Percent() + 5.Px();

            var sum = Length + calcSum;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px + 10% + 5px", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfLengthValue()
        {
            var Length = 5.Px();
            var calcProdct = 10.Px() * 3;

            var sum = Length + calcProdct;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("5px + 10px * 3", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfPercentageValue()
        {
            var Length = 5.Px();
            var calcProdct = 10.Percent() * 3;

            var sum = Length + calcProdct;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px + 10% * 3", sum.ToString());
        }

        [Fact]
        public void CanAddCalcProductOfLengthPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = (10.Percent() + 15.Px()) * 2;

            var sum = Length + calcSum;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px + (10% + 15px) * 2", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToPercentageValue()
        {
            var Length = 5.Px();
            var percentage = 10.Percent();

            var sum = percentage + Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("10% + 5px", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfLengthValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Px() + 1.Cm();

            var sum = calcSum + Length;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("10px + 1cm + 5px", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = calcSum + Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("10% + 1% + 5px", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcSumOfLengthPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Percent() + 15.Px();

            var sum = calcSum + Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("10% + 15px + 5px", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfLengthValue()
        {
            var Length = 5.Px();
            var calcProdct = 10.Px() * 3;

            var sum = calcProdct + Length;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("10px * 3 + 5px", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfPercentageValue()
        {
            var Length = 5.Px();
            var calcProdct = 10.Percent() * 3;

            var sum = calcProdct + Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("10% * 3 + 5px", sum.ToString());
        }

        [Fact]
        public void CanBeAddedToCalcProductOfLengthPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = (10.Percent() + 15.Px()) * 2;

            var sum = calcSum + Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("(10% + 15px) * 2 + 5px", sum.ToString());
        }

        [Fact]
        public void CanSubtractLengthValue()
        {
            var Length1 = 5.Px();
            var Length2 = 1.Cm();

            var sum = Length1 - Length2;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("5px - 1cm", sum.ToString());
        }

        [Fact]
        public void CanSubtractPercentageValue()
        {
            var Length = 5.Px();
            var percentage = 10.Percent();

            var sum = Length - percentage;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px - 10%", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfLengthValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Px() + 1.Cm();

            var sum = Length - calcSum;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("5px - 10px + 1cm", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = Length - calcSum;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px - 10% + 1%", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcSumOfLengthPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Percent() + 5.Px();

            var sum = Length - calcSum;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px - 10% + 5px", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfLengthValue()
        {
            var Length = 5.Px();
            var calcProdct = 10.Px() * 3;

            var sum = Length - calcProdct;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("5px - 10px * 3", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfPercentageValue()
        {
            var Length = 5.Px();
            var calcProdct = 10.Percent() * 3;

            var sum = Length - calcProdct;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px - 10% * 3", sum.ToString());
        }

        [Fact]
        public void CanSubtractCalcProductOfLengthPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = (10.Percent() + 15.Px()) * 2;

            var sum = Length - calcSum;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("5px - (10% + 15px) * 2", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedToPercentageValue()
        {
            var Length = 5.Px();
            var percentage = 10.Percent();

            var sum = percentage - Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("10% - 5px", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedToCalcSumOfLengthValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Px() + 1.Cm();

            var sum = calcSum - Length;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("10px + 1cm - 5px", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedToCalcSumOfPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Percent() + 1.Percent();

            var sum = calcSum - Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("10% + 1% - 5px", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedToCalcSumOfLengthPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = 10.Percent() + 15.Px();

            var sum = calcSum - Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("10% + 15px - 5px", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedToCalcProductOfLengthValue()
        {
            var Length = 5.Px();
            var calcProdct = 10.Px() * 3;

            var sum = calcProdct - Length;

            Assert.Equal(typeof(CalcSum<LengthValue>), sum.GetType());
            Assert.Equal("10px * 3 - 5px", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedToCalcProductOfPercentageValue()
        {
            var Length = 5.Px();
            var calcProdct = 10.Percent() * 3;

            var sum = calcProdct - Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("10% * 3 - 5px", sum.ToString());
        }

        [Fact]
        public void CanBeSubtractedToCalcProductOfLengthPercentageValue()
        {
            var Length = 5.Px();
            var calcSum = (10.Percent() + 15.Px()) * 2;

            var sum = calcSum - Length;

            Assert.Equal(typeof(CalcSum<LengthPercentageValue>), sum.GetType());
            Assert.Equal("(10% + 15px) * 2 - 5px", sum.ToString());
        }


        [Fact]
        public void CanMultiplyByInt()
        {
            var Length = 5.Px();

            var product = 2 * Length;

            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
            Assert.Equal("2 * 5px", product.ToString());
        }

        [Fact]
        public void CanMultiplyByDouble()
        {
            var Length = 5.Px();

            var product = 2.5 * Length;

            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
            Assert.Equal("2.5 * 5px", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByInt()
        {
            var Length = 5.Px();

            var product = Length * 2;

            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
            Assert.Equal("5px * 2", product.ToString());
        }

        [Fact]
        public void CanBeMultipliedByDouble()
        {
            var Length = 5.Px();

            var product = Length * 2.5;

            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
            Assert.Equal("5px * 2.5", product.ToString());
        }

        [Fact]
        public void CanBeDividedByInt()
        {
            var Length = 5.Px();

            var product = Length / 2;

            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
            Assert.Equal("5px / 2", product.ToString());
        }

        [Fact]
        public void CanBeDividedByDouble()
        {
            var Length = 5.Px();

            var product = Length / 2.5;

            Assert.Equal(typeof(CalcProduct<LengthValue>), product.GetType());
            Assert.Equal("5px / 2.5", product.ToString());
        }
    }
}
