namespace _07MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int count = 1;
            int maxCount = int.MinValue;
            int consecutiveNumber = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int firstNum = numbers[i];

                if (firstNum == numbers[i + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        consecutiveNumber = firstNum;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            int[] consecutive = new int[maxCount];

            for (int i = 0; i < maxCount; i++)
            {
                consecutive[i] = consecutiveNumber;
            }

            Console.WriteLine(string.Join(" ", consecutive));
        }
    }
}
