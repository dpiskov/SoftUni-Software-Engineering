namespace _05CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputToCharArray = input.ToCharArray();

            foreach (char c in inputToCharArray)
            {
                Console.WriteLine(c);
            }
        }
    }
}
