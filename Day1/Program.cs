// See https://aka.ms/new-console-template for more information

using Day1;

var fileContent = File.ReadLines("./CalibrationDoc.txt");

Console.WriteLine("Part 1: The sum of all calibration values is: ");
Console.WriteLine(PartOne.CalibrationValuesSum(fileContent));

Console.WriteLine("Part 2: The real sum of all calibration values is: ");
Console.WriteLine(PartTwo.CalibrationValuesRealSum(fileContent));