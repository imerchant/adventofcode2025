using AdventOfCode2025.Day01;
using AdventOfCode2025.Inputs;
using FluentAssertions;

namespace AdventOfCode2025.Tests;

public class Day01Solutions
{
    [Fact]
    public void Puzzle1_CountZeroes()
    {
        new Dial().Spin(Input.Day01).Should().Be(1105);
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
        var dial = new Dial();
        dial.Spin(Example1).Should().Be(3);
    }
}