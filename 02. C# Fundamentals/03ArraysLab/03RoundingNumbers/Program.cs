namespace _03RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double originalNumber = numbers[i];
                double roundedNumber = (int)Math.Round(originalNumber, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{originalNumber} => {roundedNumber}");
            }
        }
    }
}
