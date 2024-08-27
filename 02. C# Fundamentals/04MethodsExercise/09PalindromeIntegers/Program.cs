
namespace _09PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isPalindromeInteger = CheckIfNumberIsPalindromeInteger(input);

                if (isPalindromeInteger)
                {
                    Console.WriteLine("true");
                }
                else if (!isPalindromeInteger)
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }
        }

        static bool CheckIfNumberIsPalindromeInteger(string? input)
        {
            char[] inputToChar = input.ToCharArray();

            bool isEqual = true;

            for (int i = 0; i < inputToChar.Length / 2; i++)
            {
                char firstChar = inputToChar[i];
                char secondChar = inputToChar[inputToChar.Length - i - 1];

                if (firstChar != secondChar)
                {
                    isEqual = false;
                }
            }

            if (isEqual)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
