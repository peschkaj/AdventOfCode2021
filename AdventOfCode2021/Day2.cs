namespace AdventOfCode2021;

public class Day2
{
    public int Part1(string input)
    {
        var lines = input.Split("\n")
            .Select(x =>
            {
                var words = x.Split(" ");
                return (words[0], int.Parse(words[1]));
            });
        var destination = Moves(lines);
        return destination.horizontal * destination.vertical;
    }
    
    private (int horizontal, int vertical) Moves(IEnumerable<(string, int)> instructions)
    {
        int h = 0, v = 0;
        foreach (var (direction, distance) in instructions)
        {
            switch (direction)
            {
                case "forward": 
                    h += distance;
                    break;
                case "up":
                    v -= distance;
                    break;
                case "down":
                    v += distance;
                    break;
            }
        }
        
        return (h,v);
    }

    public int Part2(string input)
    {
        var lines = input.Split("\n")
            .Select(x =>
            {
                var words = x.Split(" ");
                return (words[0], int.Parse(words[1]));
            });
        var destination = ProcessMoves(lines);
        return destination.position * destination.depth;
    }

    private (int position, int depth) ProcessMoves(IEnumerable<(string, int)> instructions)
    {
        var aim = 0;
        var position = 0;
        var depth = 0;
        
        foreach (var (direction, distance) in instructions)
        {
            switch (direction)
            {
                case "forward": 
                    position += distance;
                    if (aim > 0)
                    {
                        depth += aim * distance;
                    }
                    break;
                case "up":
                    aim -= distance;
                    break;
                case "down":
                    aim += distance;
                    break;
            }
        }
        
        return (position,depth);
    }
}