using CsCss.Values.Text.String;
using Xunit;

namespace CsCss.Tests.Values.Text.String
{
    public class StringValueTests
    {
        [Fact]
        public void RendersStringValues()
        {
            var stringValue = new StringValue("test");
            Assert.Equal("'test'", stringValue.ToString());
        }

        [Fact]
        public void CanConvertFromString()
        {
            StringValue stringValue = "test";
            Assert.Equal("'test'", stringValue.ToString());
        }
    }
}
