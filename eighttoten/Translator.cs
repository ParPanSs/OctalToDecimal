namespace eighttoten;

public class Translator
{
    private int[] _numbers;
    private int _sum;

    public Translator(int[] numbers, int sum)
    {
        _numbers = numbers;
        _sum = sum;
    }

    public void AddNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Add a number to array: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            if (numbers[i] > 7 || numbers[i] < 0)
            {
                Console.WriteLine("Number can't be out of range 0-7. Try again.");
                i--;
            }
        }
        Array.Reverse(numbers);
    }
    public int Summator(IList<int> numbers, int sum)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] *= Convert.ToInt32(Math.Pow(8, i));
            sum += numbers[i];
        }
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        return sum;
    }
}