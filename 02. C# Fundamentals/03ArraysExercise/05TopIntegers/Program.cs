namespace _05TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            List<int> topIntegers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isGreater = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] >= numbers[i])
                    {
                        isGreater = false;
                        break;
                    }
                }

                if (isGreater)
                {
                    topIntegers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}
