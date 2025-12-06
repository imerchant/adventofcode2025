using AdventOfCode2025.Day02;
using AdventOfCode2025.Inputs;
using FluentAssertions;

namespace AdventOfCode2025.Tests;

public class Day02Solutions
{
    [Fact]
    public void Puzzle1_SumInvalidIds()
    {
        var ids = new ProductIds(Input.Day02);

        ids.RepeatedExactlyTwiceSum.Should().Be(24043483400L);
    }

    public const string Example = "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";

    [Theory]
    [InlineData("11-22", 33)]
    [InlineData(Example, 1227775554)]
    public void Puzzle1_ExamplePasses(string input, long expected)
    {
        var ids = new ProductIds(input);
        ids.RepeatedExactlyTwiceSum.Should().Be(expected);
    }
}