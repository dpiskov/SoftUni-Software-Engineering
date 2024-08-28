namespace _02GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> list = new List<int>();

            for (int i = 1; i <= numbers.Count / 2; i++)
            {
                int firstNumber;
                int secondNumber;

                if (i == 1)
                {
                    firstNumber = numbers[0];
                    secondNumber = numbers[numbers.Count - 1];
                }
                else
                {
                    firstNumber = numbers[i];
                    secondNumber = numbers[numbers.Count - i];
                }

                numbers[i] += secondNumber;
                numbers.RemoveAt(numbers.Count - i);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
