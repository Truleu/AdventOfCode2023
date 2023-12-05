using Day1;

var fileContent = File.ReadLines("./CalibrationDoc.txt");

var partOneResult = PartOne.CalibrationValuesSum(fileContent);
var partTwoResult = PartTwo.CalibrationValuesRealSum(fileContent);

Console.WriteLine("Part 1: The sum of all calibration values is: ");
Console.WriteLine(partOneResult);

Console.WriteLine("Part 2: The real sum of all calibration values is: ");
Console.WriteLine(partTwoResult);