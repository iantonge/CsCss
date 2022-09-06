using Xunit;
using static CsCss.Keywords;

namespace CsCss.Tests
{
    public class DocumentTests
    {
        [Fact]
        public void RendersDocument()
        {
            var document = new Document()
            {
                [".my-class"] = new Declarations()
                {
                    [Height] = 10.Px(),
                    [Color] = Red
                }
            };

            var expected =
@".my-class {
    height: 10px;
    color: red;
}".Replace("\r\n", "\n");

            Assert.Equal(expected, document.ToString());
        }
    }
}
