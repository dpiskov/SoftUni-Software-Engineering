namespace _04Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string numbers = string.Empty;
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
                numbers += i + " ";
            }

            Console.WriteLine(numbers.TrimEnd());
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
