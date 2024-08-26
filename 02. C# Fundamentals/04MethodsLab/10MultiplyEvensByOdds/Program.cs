using System.Security.Cryptography;

namespace _10MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int even = GetSumOfEvenDigits(number);
            int odd = GetSumOfOddDigits(number);
            int multiple = GetMultipleOfEvenAndOdds(even, odd);

            Console.WriteLine(multiple);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int even = 0;

            while (number > 0)
            {
                int n = number % 10;
                number = number / 10;

                if (n % 2 == 0)
                {
                    even += n;
                }
            }

            return even;
        }

        static int GetSumOfOddDigits(int number)
        {
            int odd = 0;

            while (number > 0)
            {
                int n = number % 10;
                number = number / 10;

                if (n % 2 != 0)
                {
                    odd += n;
                }
            }

            return odd;
        }

        static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            return even * odd;
        }
    }
}
