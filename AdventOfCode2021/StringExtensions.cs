namespace AdventOfCode2021;

public static class StringExtensions 
{
    public static string[] Lines(this String str) {
        return str.Split(Environment.NewLine);
    }
}