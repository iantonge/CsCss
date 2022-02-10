using Xunit;

namespace CsCss.Tests
{
    public class SelectorTests
    {
        [Fact]
        public void CanConvertFromString()
        {
            Selector selector = ".my-class";
            Assert.Equal(".my-class", selector.ToString());
        }
    }
}
