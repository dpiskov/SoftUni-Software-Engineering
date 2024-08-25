namespace _02PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double dollarCourse = 1.31;

            double pounds = double.Parse(Console.ReadLine());

            double poundsToDollars = pounds * dollarCourse;

            Console.WriteLine($"{poundsToDollars:f3}");
        }
    }
}
