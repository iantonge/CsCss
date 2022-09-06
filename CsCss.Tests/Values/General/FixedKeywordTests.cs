using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class FixedKeywordTests
    {
        [Fact]
        public void RendersFixedKeyword()
        {
            Assert.Equal("fixed", Keywords.Fixed.ToString());
            Assert.Equal(typeof(FixedKeyword), Keywords.Fixed.GetType());
        }
    }
}
