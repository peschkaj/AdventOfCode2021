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

    public int Part2(string input) {
        var lines = input.Lines();

        var oxygen = GetRating(lines, "1", "0");
        var carbon = GetRating(lines, "0", "1");

        return oxygen * carbon;
    }

    
    private static int GetRating(string[] lines, string onesChar, string zerosChar)
    {
        string[] rating = lines;
        for (int i = 0; i < lines[1].Length; i++)
        {
            int ones = rating.Where(s => s.Substring(i, 1) == "1").Count();
            int zeros = rating.Where(s => s.Substring(i, 1) == "0").Count();

            string character = (ones >= zeros) ? onesChar : zerosChar;
            rating = rating.Where(s => s.Substring(i, 1) == character).ToArray();

            if (rating.Length == 1)
            {
                break;
            }
        }

        return Convert.ToInt32(rating[0], 2);
    }
}