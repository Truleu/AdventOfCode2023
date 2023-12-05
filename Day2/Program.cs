using Day2;

var fileContent = File.ReadAllLines("./Games.txt");

var partOneResult = PartOne.PossibleGamesSum(fileContent);

Console.WriteLine("Part 1: The sum of all possible games is: ");
Console.WriteLine(partOneResult);