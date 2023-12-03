namespace Day1;
public static class PartTwo
{
  public static int CalibrationValuesRealSum(IEnumerable<string> values)
  {
    Dictionary<string, int> convertNumbers = new()
    {
      { "one", 1 },
      { "two", 2 },
      { "three", 3 },
      { "four", 4 },
      { "five", 5 },
      { "six", 6 },
      { "seven", 7 },
      { "eight", 8 },
      { "nine", 9 }
    };

    List<int> numbers = [];
    foreach (string value in values)
    {
      Dictionary<int, int> numbersIndex = new();
      for (int i = 0; i < value.Length; i++)
      {
        if (Char.IsDigit(value[i]))
          numbersIndex.Add(i, int.Parse(value[i].ToString()));
      }

      var keyVal = convertNumbers.Where(n => value.Contains(n.Key, StringComparison.CurrentCultureIgnoreCase));
      foreach (var (key, val) in keyVal)
      {
        var index = value.IndexOf(key);
        var lastIndex = value.LastIndexOf(key);
        //newStrReplace = newStrReplace.Insert(index, val.ToString());
        numbersIndex.Add(index, val);
        if (lastIndex != index)
          numbersIndex.Add(lastIndex, val);
      }

      var firstNumber = numbersIndex.OrderBy(n => n.Key).First().Value;
      var lastNumber = numbersIndex.OrderByDescending(n => n.Key).First().Value;

      numbers.Add(int.Parse($"{firstNumber}{lastNumber}"));
    }

    return numbers.Sum();
  }
}
