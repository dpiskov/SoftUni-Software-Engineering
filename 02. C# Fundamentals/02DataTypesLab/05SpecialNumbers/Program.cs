namespace _05SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int numberCopy = i;
                int numToCheck = 0;

                if (numberCopy >= 10)
                {
                    numToCheck = numberCopy / 10;
                    numToCheck += numberCopy % 10;
                }
                else
                {
                    numToCheck = numberCopy;
                }

                if (numToCheck == 5 || numToCheck == 7 || numToCheck == 11)
                {
                    Console.WriteLine($"{numberCopy} -> True");
                }
                else
                {
                    Console.WriteLine($"{numberCopy} -> False");
                }
            }
        }
    }
}
