namespace _06MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputToChar = input.ToCharArray();

            if (inputToChar.Length % 2 == 0)
            {
                char firstChar = inputToChar[inputToChar.Length / 2 - 1];
                char secondChar = inputToChar[inputToChar.Length / 2];
                Console.WriteLine($"{firstChar}{secondChar}");
            }
            else
            {
                char character = inputToChar[inputToChar.Length / 2];

                Console.WriteLine(character);
            }
        }
    }
}
