using AdventOfCode2025.Day03;
using AdventOfCode2025.Inputs;
using FluentAssertions;

namespace AdventOfCode2025.Tests;

public class Day03Solutions
{
    [Fact]
    public void Puzzle1_FindTotalJoltage()
    {
        new Batteries(Input.Day03).JoltageBy2.Should().Be(17432L);
    }

    public const string Example1 =
"""
987654321111111
811111111111119
234234234234278
818181911112111
""";

    [Theory]
    [InlineData(Example1, 357)]
    [InlineData("987654321111111", 98)]
    [InlineData("811111111111119", 89)]
    [InlineData("234234234234278", 78)]
    [InlineData("818181911112111", 92)]
    public void Puzzle1_ExamplePasses(string input, long expected)
    {
        new Batteries(input).JoltageBy2.Should().Be(expected);
    }
}