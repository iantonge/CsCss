using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsCss.Values.Line;
using Xunit;

namespace CsCss.Tests.Values.Line;

public class LineWidthValueTests
{
    [Fact]
    public void CanConvertFromLength()
    {
        LineWidthValue converted = 10.Px();
        Assert.Equal("10px", converted.ToString());
    }
}
