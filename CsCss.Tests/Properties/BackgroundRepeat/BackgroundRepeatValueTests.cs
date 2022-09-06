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
            BackgroundRepeatValue converted = Keywords.RepeatX;
            Assert.Equal("repeat-x", converted.ToString());
        }

        [Fact]
        public void CanConvertFromKeywordTuple()
        {
            BackgroundRepeatValue converted = (Keywords.Space, Keywords.NoRepeat);
            Assert.Equal("space no-repeat", converted.ToString());
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithHorizontalRepeatX()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (Keywords.RepeatX, Keywords.NoRepeat);
            });
            Assert.Equal("RepeatX may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithVerticalRepeatX()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (Keywords.NoRepeat, Keywords.RepeatX);
            });
            Assert.Equal("RepeatX may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithHorizontalRepeatY()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (Keywords.RepeatY, Keywords.NoRepeat);
            });
            Assert.Equal("RepeatY may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithVerticalRepeatY()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (Keywords.NoRepeat, Keywords.RepeatY);
            });
            Assert.Equal("RepeatY may only be used with the one-value syntax", exception.Message);
        }
    }
}
