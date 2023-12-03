namespace Day1;
public static class PartOne
{
  public static int CalibrationValuesSum(IEnumerable<string> values)
  {
    List<int> numbers = [];
    foreach (var value in values)
    {
      string extractNumber = string.Concat(value.ToString().Where(Char.IsDigit));
      numbers.Add(int.Parse($"{extractNumber[..1]}{extractNumber.Substring(extractNumber.Length - 1, 1)}"));
    }

    return numbers.Sum();
  }
}
