namespace _04SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char letters = char.Parse(Console.ReadLine());

                sum += (int)letters;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
