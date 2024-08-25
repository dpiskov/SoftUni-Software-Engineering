namespace _12RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numToCheck = 0;
            bool isValid = false;

            for (int i = 1; i <= n; i++)
            {
                int numberCopy = i;
                while (i > 0)
                {
                    numToCheck += i % 10;
                    i = i / 10;
                }
                isValid = (numToCheck == 5) || (numToCheck == 7) || (numToCheck == 11);
                Console.WriteLine("{0} -> {1}", numberCopy, isValid);
                numToCheck = 0;
                i = numberCopy;
            }

        }
    }
}
