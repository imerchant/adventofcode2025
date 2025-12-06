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
}