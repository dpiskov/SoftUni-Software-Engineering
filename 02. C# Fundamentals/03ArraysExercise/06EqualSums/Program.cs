namespace _06EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                int rightSum = 0;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
