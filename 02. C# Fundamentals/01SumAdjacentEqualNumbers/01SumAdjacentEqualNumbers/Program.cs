namespace _01SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 1; i < numbers.Count - 1;)
            {
                int firstNumber = numbers[i - 1];
                int secondNumber = numbers[i];


                if (firstNumber == secondNumber)
                {
                    numbers[i - 1] += secondNumber;
                    numbers.Remove(secondNumber);
                    i--;
                    continue;
                }

                i++;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
