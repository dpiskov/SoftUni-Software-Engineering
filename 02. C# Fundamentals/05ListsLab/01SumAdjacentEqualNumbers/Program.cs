namespace _01SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                double firstNumber = numbers[i - 1];
                double secondNumber = numbers[i];


                if (firstNumber == secondNumber)
                {
                    numbers[i - 1] += secondNumber;
                    numbers.Remove(secondNumber);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
