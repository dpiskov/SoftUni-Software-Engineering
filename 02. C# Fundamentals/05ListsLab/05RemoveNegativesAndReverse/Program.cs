namespace _05RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count;)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int firstNumber = numbers[i];
                int secondNumber = numbers[numbers.Count - i - 1];

                numbers[i] = secondNumber;
                numbers[numbers.Count - i - 1] = firstNumber;
            }

            if (numbers.Any())
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
