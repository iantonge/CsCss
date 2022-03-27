﻿using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundClip
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundRepeatFromKeyword()
        {
            var declarations = new Declarations()
            {
                [Statics.BackgroundClip] = Statics.BorderBox
            };

            Assert.Equal("background-clip: border-box", declarations.ToStrings().Single());
        }
    }
}
