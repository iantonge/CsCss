using CsCss.Properties.BackgroundPosition;
using CsCss.Properties.BackgroundRepeat;
using System;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundRepeat
{
    public class BackgroundRepeatValueTests
    {
        [Fact]
        public void CanConvertFromKeyword()
        {
            BackgroundRepeatValue converted = RepeatX;
            Assert.Equal("repeat-x", converted.ToString());
        }

        [Fact]
        public void CanConvertFromKeywordTuple()
        {
            BackgroundRepeatValue converted = (Space, NoRepeat);
            Assert.Equal("space no-repeat", converted.ToString());
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithHorizontalRepeatX()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (RepeatX, NoRepeat);
            });
            Assert.Equal("RepeatX may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithVerticalRepeatX()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (NoRepeat, RepeatX);
            });
            Assert.Equal("RepeatX may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithHorizontalRepeatY()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (RepeatY, NoRepeat);
            });
            Assert.Equal("RepeatY may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithVerticalRepeatY()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (NoRepeat, RepeatY);
            });
            Assert.Equal("RepeatY may only be used with the one-value syntax", exception.Message);
        }
    }
}
