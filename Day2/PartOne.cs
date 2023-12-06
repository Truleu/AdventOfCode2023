namespace Day2;
public static class PartOne
{
  //Bag loaded with only 12 red cubes, 13 green cubes and 14 blue cubes
  public static int PossibleGamesSum(IEnumerable<string> games)
  {
    List<int> numbers = new();
    Game gameObj = new();
    foreach (var game in games)
    {
      var gameSplit = game.Split(':');
      gameObj.GameId = int.Parse(gameSplit[0].Split(' ')[1]);

      List<string> handful = new();
      handful.AddRange(gameSplit[1].Split(';'));
      var handfulOfRandomCubes = gameSplit[1].Split(';');
      for (var i = 0; i < handfulOfRandomCubes.Length; i++){
        var cubes = handfulOfRandomCubes[i].Split(',');
    }
  }
    return 0;
  }
}
