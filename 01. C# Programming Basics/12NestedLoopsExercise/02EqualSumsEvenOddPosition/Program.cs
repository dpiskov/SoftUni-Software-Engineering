namespace _02EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = start; i <= end; i++)
            {
                string number = i.ToString();
                char[] stringToChar = number.ToCharArray();

                int evenPosition = 0;
                int oddPosition = 0;

                for (int j = 0; j < stringToChar.Length; j++)
                {
                    int charToInt = int.Parse(stringToChar[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenPosition += charToInt;
                    }
                    else if (j % 2 != 0)
                    {
                        oddPosition += charToInt;
                    }
                }

                if (evenPosition == oddPosition)
                {
                    output += $"{i} ";
                }
            }

            Console.WriteLine(output.TrimEnd());
        }
    }
}
