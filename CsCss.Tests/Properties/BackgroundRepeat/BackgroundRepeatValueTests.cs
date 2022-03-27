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
            BackgroundRepeatValue converted = Statics.RepeatX;
            Assert.Equal("repeat-x", converted.ToString());
        }

        [Fact]
        public void CanConvertFromKeywordTuple()
        {
            BackgroundRepeatValue converted = (Statics.Space, Statics.NoRepeat);
            Assert.Equal("space no-repeat", converted.ToString());
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithHorizontalRepeatX()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (Statics.RepeatX, Statics.NoRepeat);
            });
            Assert.Equal("RepeatX may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithVerticalRepeatX()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (Statics.NoRepeat, Statics.RepeatX);
            });
            Assert.Equal("RepeatX may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithHorizontalRepeatY()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (Statics.RepeatY, Statics.NoRepeat);
            });
            Assert.Equal("RepeatY may only be used with the one-value syntax", exception.Message);
        }

        [Fact]
        public void ThrowsOnConvertingFromKeywordTupleWithVerticalRepeatY()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                BackgroundRepeatValue converted = (Statics.NoRepeat, Statics.RepeatY);
            });
            Assert.Equal("RepeatY may only be used with the one-value syntax", exception.Message);
        }
    }
}
