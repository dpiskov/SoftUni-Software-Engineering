namespace _09KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Dictionary<int, int[]> keyValuePairs = new Dictionary<int, int[]>();

            while (input != "Clone them!")
            {
                int[] numbers = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int count = 0;
                int maxCount = int.MinValue;
                int index = 0;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int firstNum = numbers[i];

                    if (firstNum == numbers[i + 1])
                    {
                        count++;

                        if (count > maxCount)
                        {
                            index = i;
                            maxCount = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }

                }

                keyValuePairs.Add(index, numbers);

                input = Console.ReadLine();
            }

            int sum = int.MinValue;
            int secondIndex = 0;
            int[] array = new int[length];

            foreach (var kvp in keyValuePairs)
            {
                if (kvp.Value.Sum() > sum)
                {
                    sum = kvp.Value.Sum();
                    secondIndex = kvp.Key;
                    array = kvp.Value;
                }
            }

            Console.WriteLine($"Best DNA sample {secondIndex} with sum: {sum}.");
            Console.WriteLine($"{string.Join(" ", array)}");
        }
    }
}
