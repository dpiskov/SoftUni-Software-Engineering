namespace _02PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                numbers[i] = number;
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int firstNum = numbers[i];
                int secondNum = numbers[numbers.Length - 1 - i];
                numbers[i] = secondNum;
                numbers[numbers.Length - 1 - i] = firstNum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
