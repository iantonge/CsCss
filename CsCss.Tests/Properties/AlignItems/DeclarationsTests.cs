﻿using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.AlignItems
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetAlignItems()
        {
            var declarations = new Declarations()
            {
                [Keywords.AlignItems] = Normal
            };

            Assert.Equal("align-items: normal", declarations.ToStrings().Single());
        }
    }
}
