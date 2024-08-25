namespace _04ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < input.Length / 2; i++)
            {
                string firstChar = input[i];
                string secondChar = input[input.Length - 1 - i];
                input[i] = secondChar;
                input[input.Length - 1 - i] = firstChar;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
