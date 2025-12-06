using AdventOfCode2025.Day01;
using AdventOfCode2025.Inputs;
using FluentAssertions;

namespace AdventOfCode2025.Tests;

public class Day01Solutions
{
    [Fact]
    public void Puzzle1and2_CountZeroes()
    {
        new Dial().Spin(Input.Day01).Should().Be(1105);
        new Dial().Spin2(Input.Day01).Should().Be(6599);
    }

    public const string Example1 = """
L68
L30
R48
L5
R60
L55
L1
L99
R14
L82
""";

    [Fact]
    public void Puzzle1_ExamplePasses()
    {
        new Dial().Spin(Example1).Should().Be(3);
    }

    [Theory]
    [InlineData(Example1, 6)]
    [InlineData("R1000", 10)]
    public void Puzzle2_ExamplePasses(string input, int expected)
    {
        new Dial().Spin2(input).Should().Be(expected);
    }
}