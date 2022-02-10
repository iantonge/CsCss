using CsCss.Values.Text.Keyword.Sizing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CsCss.Tests.Values.Text.Keyword.Sizing
{
    public class StaticsTests
    {
        [Fact]
        public void RendersFitContentKeyword()
        {
            Assert.Equal("fit-content", Statics.FitContent().ToString());
            Assert.Equal(typeof(FitContentKeyword), Statics.FitContent().GetType());
        }

        [Fact]
        public void RendersMaxContentKeyword()
        {
            Assert.Equal("max-content", Statics.MaxContent.ToString());
            Assert.Equal(typeof(MaxContentKeyword), Statics.MaxContent.GetType());
        }

        [Fact]
        public void RendersMinContentKeyword()
        {
            Assert.Equal("min-content", Statics.MinContent.ToString());
            Assert.Equal(typeof(MinContentKeyword), Statics.MinContent.GetType());
        }
    }
}
