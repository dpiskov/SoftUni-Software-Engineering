namespace _06Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int copyOfNumber = number;

            List<int> list = new List<int>();

            while (copyOfNumber > 0)
            {
                list.Add(copyOfNumber % 10);
                copyOfNumber /= 10;
            }

            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int factorial = 1;

                if (list[i] > 1)
                {
                    for (int j = list[i]; j > 0; j--)
                    {
                        factorial *= j;
                    }

                }

                sum += factorial;
            }

            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
