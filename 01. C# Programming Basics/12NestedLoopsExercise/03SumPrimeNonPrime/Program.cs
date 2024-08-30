namespace _03SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                if (number == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int combinations = 0;

                for (int i = 1; i <= number; i++)
                {
                    for (int j = i; j <= number; j++)
                    {
                        int result = i * j;

                        if (result == number)
                        {
                            combinations++;
                        }
                    }
                }

                if (combinations == 1)
                {
                    primeSum += number;
                }
                else if (combinations > 1)
                {
                    nonPrimeSum += number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
