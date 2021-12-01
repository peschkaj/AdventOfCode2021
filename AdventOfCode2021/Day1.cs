using System.Collections.Generic;
using System.Net.Sockets;

namespace AdventOfCode2021;

public class Day1
{
    public int CountDescending(string lines)
    {
        return CountDescending(lines.Split("\n").Select(x => Int32.Parse(x)).ToArray());
    }
    public int CountDescending(int[] entries)
    {
        return entries.Select((x, i) => i < entries.Length - 1 && entries[i + 1] > entries[i]).Count(x => x);
    }

    public int CountChunks(string lines)
    {
        var entries = lines.Split("\n").Select(x => Int32.Parse(x)).ToArray();
        return CountDescending( entries.Select((x, i) => i < entries.Length - 2 ? entries[i..(i + 3)].Sum() : 0).ToArray());
    }
}