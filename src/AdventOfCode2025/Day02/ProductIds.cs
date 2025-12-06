namespace AdventOfCode2025.Day02;

public class ProductIds
{
    public long RepeatedExactlyTwiceSum { get; set; }

    public ProductIds(string input)
    {
        var ranges = input.Split(',').Select<string, (long x, long y)>(range =>
        {
            var r = range.Split('-');
            return (long.Parse(r[0]), long.Parse(r[1]));
        });

        List<string> nums = [.. ranges
            .SelectMany(range => Range(range.x, range.y - range.x + 1))
            .Select(x => x.ToString())];

        RepeatedExactlyTwiceSum = nums
            .Where(x => x.Length % 2 == 0)
            .Where(x => x[..(x.Length / 2)] == x[(x.Length / 2)..])
            .Sum(long.Parse);

        static IEnumerable<long> Range(long start, long count)
        {
            for (long k = 0; k < count; k++)
            {
                yield return start + k;
            }
        }
    }
}