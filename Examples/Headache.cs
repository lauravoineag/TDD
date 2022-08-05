namespace Examples;

public class Headache
{
    public IEnumerable<int> MultiplyList(IEnumerable<int> numbers, int multiplier)
    {
        //return numbers.Select(number => number * 5);
        foreach (int number in numbers)
        {
            yield return number * 5;
        }
    }
}