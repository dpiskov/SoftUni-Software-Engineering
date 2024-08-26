


namespace _09GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            if (valueType == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                int result = GetMax(firstNum, secondNum);
            }
            else if (valueType == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                char result = GetMax(firstChar, secondChar);
            }
            else if (valueType == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                string result = GetMax(firstString, secondString);
            }
        }

        static string GetMax(string? firstString, string? secondString)
        {
            throw new NotImplementedException();
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if ((int)firstChar > (int)secondChar)
            {
                return firstChar;
            }

            return secondChar;
        }

        static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }

            return secondNum;
        }
    }
}
