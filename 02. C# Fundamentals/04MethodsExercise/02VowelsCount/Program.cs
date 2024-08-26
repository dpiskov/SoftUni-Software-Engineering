
namespace _02VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            CountVowelsOfString(input);


        }

        static void CountVowelsOfString(string? input)
        {
            int vowels = 0;

            foreach (var letter in input.ToLower())
            {
                switch (letter)
                {
                    case 'a': vowels++; break;
                    case 'e': vowels++; break;
                    case 'i': vowels++; break;
                    case 'o': vowels++; break;
                    case 'u': vowels++; break;
                }
            }

            Console.WriteLine(vowels);
        }
    }
}
