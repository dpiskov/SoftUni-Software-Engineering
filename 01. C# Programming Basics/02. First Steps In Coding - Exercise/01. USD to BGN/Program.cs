namespace _01._USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double fixedDollarToBgn = 1.79549;
            double dollars = double.Parse(Console.ReadLine());

            double dollarsToBgn = dollars * fixedDollarToBgn;

            Console.WriteLine(dollarsToBgn);
        }
    }
}
