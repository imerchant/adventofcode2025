using AdventOfCode2025.Day02;
using AdventOfCode2025.Inputs;
using FluentAssertions;

namespace AdventOfCode2025.Tests;

public class Day02Solutions
{
    [Fact]
    public void Puzzle1and2_SumInvalidIds()
    {
        var ids = new ProductIds(Input.Day02);

        ids.RepeatedExactlyTwiceSum.Should().Be(24043483400L);
        ids.RepeatedAtLeastTwiceSum.Should().Be(38262920235L);
    }

    public const string Example = "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";

    [Theory]
    [InlineData("11-22", 33, 33)]
    [InlineData("95-115", 99, 99+111)]
    [InlineData(Example, 1227775554, 4174379265)]
    [InlineData("1188511880-1188511890", 1188511885, 1188511885)]
    [InlineData("222220-222224", 222222, 222222)]
    [InlineData("1698522-1698528", 0, 0)]
    [InlineData("565653-565659", 0, 565656)]
    [InlineData("824824821-824824827", 0, 824824824)]
    [InlineData("2121212118-2121212124", 0, 2121212121)]
    [InlineData("998-1012", 1010, 999+1010)]
    [InlineData("12341234-12341235", 12341234, 12341234)]
    [InlineData("1212121212-1212121213", 0, 1212121212)]
    [InlineData("1111111-1111112", 0, 1111111)]
    public void Puzzle1_ExamplePasses(string input, long expected1, long expected2)
    {
        var ids = new ProductIds(input);
        ids.RepeatedExactlyTwiceSum.Should().Be(expected1);
        ids.RepeatedAtLeastTwiceSum.Should().Be(expected2);
    }
}