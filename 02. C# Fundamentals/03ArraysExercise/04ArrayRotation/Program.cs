namespace _04ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstNum = numbers[0];

                for (int j = 1; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];

                    numbers[j - 1] = secondNum;
                }

                numbers[numbers.Length - 1] = firstNum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
