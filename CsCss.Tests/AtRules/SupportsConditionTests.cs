using System;
using Xunit;
using static CsCss.AtRuleFunctions;

namespace CsCss.Tests.AtRules;

public class SupportsConditionTests
{
    [Fact]
    public void RendersDeclarationCondition()
    {
        var condition = Supports(new()
        {
            [Color] = Red
        });

        Assert.Equal("(color: red)", condition.ToString());
    }

    [Fact]
    public void RendersLengthDeclarationCondition()
    {
        var condition = Supports(new()
        {
            [Height] = 10.Px()
        });

        Assert.Equal("(height: 10px)", condition.ToString());
    }

    [Fact]
    public void RendersNegatedCondition()
    {
        var condition = Supports(new()
        {
            [Color] = Red
        }).Not();

        Assert.Equal("not (color: red)", condition.ToString());
    }

    [Fact]
    public void RendersAndCondition()
    {
        var condition = Supports(new()
        {
            [Color] = Red
        }).And(new()
        {
            [Height] = 10.Px()
        });

        Assert.Equal("(color: red) and (height: 10px)", condition.ToString());
    }

    [Fact]
    public void RendersOrCondition()
    {
        var condition = Supports(new()
        {
            [Color] = Red
        }).Or(new()
        {
            [Height] = 10.Px()
        });

        Assert.Equal("(color: red) or (height: 10px)", condition.ToString());
    }

    [Fact]
    public void RendersGroupedMixedCondition()
    {
        var condition = Supports(new()
        {
            [Color] = Red
        }).And(
            Supports(new()
            {
                [Height] = 10.Px()
            }).Or(new()
            {
                [Color] = Blue
            })
        );

        Assert.Equal("(color: red) and ((height: 10px) or (color: blue))", condition.ToString());
    }

    [Fact]
    public void RejectsEmptyDeclarationCondition()
    {
        Assert.Throws<ArgumentException>(() => Supports(new()));
    }

    [Fact]
    public void RejectsMultipleDeclarationCondition()
    {
        Assert.Throws<ArgumentException>(() => Supports(new()
        {
            [Color] = Red,
            [Height] = 10.Px()
        }));
    }
}
