using CsCss.Values.Sizing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CsCss.Tests.Values..Sizing
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

        [Fact]
        public void RendersAngleFitContentValue()
        {
            var result = Statics.FitContent(10.Deg());
            Assert.Equal("fit-content(10deg)", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }

        [Fact]
        public void RendersPercentageFitContentValue()
        {
            var result = Statics.FitContent(10.Percent());
            Assert.Equal("fit-content(10%)", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }

        [Fact]
        public void RendersAnglePercentageFitContentValue()
        {
            var result = Statics.FitContent(Statics.Calc(10.Percent() - 10.Deg()));
            Assert.Equal("fit-content(calc(10% - 10deg))", result.ToString());
            Assert.Equal(typeof(FitContentValue), result.GetType());
        }
    }
}
