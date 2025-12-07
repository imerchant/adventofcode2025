namespace AdventOfCode2025.Day03;

public class Batteries
{
    public long JoltageBy2 { get; set; }

    public Batteries(string input)
    {
        JoltageBy2 = input
            .SplitLines()
            .Sum(GetJoltage);

        static long GetJoltage(string bank)
        {
            HashSet<string> joltages = [];
            for (var k = 0; k < bank.Length - 1; ++k)
            {
                for (var j = k+1; j < bank.Length; ++j)
                {
                    joltages.Add($"{bank[k]}{bank[j]}");
                }
            }
            return joltages.Max(long.Parse);
        }
    }
}