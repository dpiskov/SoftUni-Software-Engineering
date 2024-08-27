

namespace _10TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int number = 1; number <= end; number++)
            {
                bool isDivisibleBy8 = CheckIfSumOfDigitsIsDivisibleBy8(number);
                bool hasOneOddDigit = CheckIfIntegerHoldsOneOddDigit(number);

                if (isDivisibleBy8 && hasOneOddDigit)
                {
                    Console.WriteLine(number);
                }
            }
        }

        private static bool CheckIfIntegerHoldsOneOddDigit(int number)
        {
            char[] numberToChar = number.ToString().ToCharArray();

            foreach (char c in numberToChar)
            {
                int charToNum = (int)c;

                if (charToNum % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }

        static bool CheckIfSumOfDigitsIsDivisibleBy8(int number)
        {
            char[] numberToChar = number.ToString().ToCharArray();

            int sum = 0;

            foreach (char c in numberToChar)
            {
                sum += (int)c;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
