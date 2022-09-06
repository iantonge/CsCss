using CsCss.Values.Line;
using Xunit;

namespace CsCss.Tests.Values.Line
{
    public class LineStyleValueTests
    {
        [Fact]
        public void CanConvertFromNoneKeyword()
        {
            LineStyleValue converted = Keywords.None;
            Assert.Equal("none", converted.ToString());
        }
    }
}
