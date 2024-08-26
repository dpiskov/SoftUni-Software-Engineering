namespace _03CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            int start = (int)firstChar;
            int end = (int)secondChar;

            List<char> chars = new List<char>();

            for (int i = start + 1; i < end; i++)
            {
                chars.Add((char)i);
            }

            Console.WriteLine(string.Join(" ", chars));
        }
    }
}
