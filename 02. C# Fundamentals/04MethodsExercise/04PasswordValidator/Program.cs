
namespace _04PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool is6To10Characters = true;
            bool isLettersAndDigits = true;
            bool is2Digits = true;

            is6To10Characters = IsPasswordContaining6To10Characters(input);
            isLettersAndDigits = IsPasswordContainingOnlyLettersAndDigits(input);
            is2Digits = IsPasswordContainingAtLeast2Digits(input);

            if (is6To10Characters && isLettersAndDigits && is2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPasswordContainingAtLeast2Digits(string? input)
        {
            int digitCount = 0;

            foreach (var c in input)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }

            if (digitCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }

            return true;
        }

        static bool IsPasswordContainingOnlyLettersAndDigits(string? input)
        {
            bool isTrue = true;

            foreach (var c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    isTrue = false;
                }
            }

            if (!isTrue)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }

            return true;
        }

        static bool IsPasswordContaining6To10Characters(string? input)
        {
            if (!(input.Length >= 6 && input.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }

            return true;
        }
    }
}
