namespace _06EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            int sumOfArray = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                sumOfArray += firstArray[i];
            }

            Console.WriteLine($"Arrays are identical. Sum: {sumOfArray}");
        }
    }
}
