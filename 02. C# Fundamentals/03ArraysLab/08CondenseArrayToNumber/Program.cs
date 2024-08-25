namespace _08CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int result = 0;
            while (numbers.Length > 1)
            {
                int[] condensed = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;

                result = condensed[0];
            }

            if (numbers.Length == 1)
            {
                result = numbers[0];
            }

            Console.WriteLine(result);
        }
    }
}
