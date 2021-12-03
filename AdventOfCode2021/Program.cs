// See https://aka.ms/new-console-template for more information

using AdventOfCode2021;

//var d = new Day1();
//Console.WriteLine(d.CountDescending(Inputs.Day1));
//Console.WriteLine(d.CountChunks(Inputs.Day1));

// var d = new Day2();
// Console.WriteLine(d.Part1(Inputs.Day2));
// Console.WriteLine(d.Part2(Inputs.Day2));

var d = new Day3();
Console.WriteLine(d.Part1(Inputs.Day3));
int? x = 1;
var y = 0;
var lol = "";

if (lol is null)
{
    
}

try
{
    Console.WriteLine(x / y);
}
catch (Exception ex)
{
    ex.Data["lol"] = "omg";
    throw;
}