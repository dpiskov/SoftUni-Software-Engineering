
namespace _07RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(input, n);

            Console.WriteLine(result);
        }

        static string RepeatString(string? input, int n)
        {
            string output = string.Empty;

            for (int i = 0; i < n; i++)
            {
                output += input;
            }

            return output;
        }
    }
}
