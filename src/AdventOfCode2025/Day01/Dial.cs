using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AdventOfCode2025.Day01;

public class Dial
{
    private static readonly Regex DialSpinRegex = new(@"(?'direction'[RL])(?'amount'\d{1,4})", RegexOptions.Compiled);

    public int Index { get; set; } = 50;

    public int Spin(string input)
    {
        var zeroCount = 0;
        var matches = DialSpinRegex.Matches(input).Cast<Match>();
        foreach (var match in matches)
        {
            var mod = match.Groups["direction"].Value[0] is 'R' ? 1 : -1;
            var amount = int.Parse(match.Groups["amount"].Value) % 100;

            Index += mod * amount;
            Index = Index switch
            {
                < 0 => Index + 100,
                > 99 => Index - 100,
                _ => Index
            };
            if (Index is 0) zeroCount++;
        }

        return zeroCount;
    }

    public int Spin2(string input)
    {
        var zeroCount = 0;
        var matches = DialSpinRegex.Matches(input).Cast<Match>();
        foreach (var match in matches)
        {
            var mod = match.Groups["direction"].Value[0] is 'R' ? 1 : -1;
            var amount = int.Parse(match.Groups["amount"].Value);
            zeroCount += (int)Math.Floor(amount / 100.0);

            var newIndex = Index + mod * (amount % 100);
            if (newIndex is 0)
            {
                zeroCount++;
                Index = newIndex;
            }
            else if (newIndex > 99)
            {
                if (Index is not 0) zeroCount++;
                Index = newIndex - 100;
            }
            else if (newIndex < 0)
            {
                if (Index is not 0) zeroCount++;
                Index = newIndex + 100;
            }
            else
            {
                Index = newIndex;
            }
            Index = Index;
        }

        return zeroCount;
    }
}