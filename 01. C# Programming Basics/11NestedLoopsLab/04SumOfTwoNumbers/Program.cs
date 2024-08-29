namespace _04SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int magicNumber = int.Parse(Console.ReadLine());
            int totalCombinations = 0;

            int firstNumber = 0;
            int secondNumber = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    totalCombinations++;

                    int result = i + j;

                    if (result == magicNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;

                        Console.WriteLine($"Combination N:{totalCombinations} ({firstNumber} + {secondNumber} = {magicNumber})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{totalCombinations} combinations - neither equals {magicNumber}");
        }
    }
}