using System.Net.Sockets;

namespace AdventOfCode2021;

public class Day3
{
    public int Part1(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var lineLength = lines.First().Length;
        var bits = new int[lineLength];
        foreach (var line in lines)
        {
            for (int i = 0; i < lineLength; i++)
            {
                if (line[i] == '1')
                {
                    bits[i]++;
                }
            }
        }

        var gamma = "";
        var epsilon = "";

        foreach (var t in bits)
        {
            if (t > (lines.Length / 2))
            {
                gamma += "1";
                epsilon += "0";
            }
            else
            {
                gamma += "0";
                epsilon += "1";
            }
        }

        return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
    }
}