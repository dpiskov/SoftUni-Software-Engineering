namespace _06VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputToCharArray = input.ToCharArray();

            int vowelsCount = 0;

            foreach (char c in inputToCharArray)
            {
                switch (c)
                {
                    case 'a': vowelsCount += 1; break;
                    case 'e': vowelsCount += 2; break;
                    case 'i': vowelsCount += 3; break;
                    case 'o': vowelsCount += 4; break;
                    case 'u': vowelsCount += 5; break;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
