using Xunit;

namespace CsCss.Tests;

public class DocumentTests
{
    [Fact]
    public void RendersDocument()
    {
        Document document = new ()
        {
            [".my-class"] = new ()
            {
                [Height] = 10.Px(),
                [Color] = Red
            }
        };

        var expected = """
            .my-class {
                height: 10px;
                color: red;
            }
            """;

        Assert.Equal(expected, document.ToString());
    }
}
