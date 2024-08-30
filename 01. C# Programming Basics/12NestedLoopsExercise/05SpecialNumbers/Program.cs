namespace _05SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = 1111; i <= 9999; i++)
            {
                char[] intToChar = i.ToString().ToCharArray();
                bool isSpecial = true;

                foreach (char c in intToChar)
                {
                    int charToInt = int.Parse(c.ToString());

                    if (charToInt == 0)
                    {
                        isSpecial = false;
                        continue;
                    }

                    if (n % charToInt != 0)
                    {
                        isSpecial = false;
                        continue;
                    }
                }

                if (isSpecial)
                {
                    output += $"{i} ";
                }
            }

            Console.WriteLine(output.TrimEnd());
        }
    }
}
