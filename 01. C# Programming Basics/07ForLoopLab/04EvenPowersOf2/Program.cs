namespace _04EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenPowers = 1;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenPowers = 1;

                    for (int j = 0; j < i; j++)
                    {

                        evenPowers *= 2;
                    }

                    Console.WriteLine(evenPowers);
                }
            }
        }
    }
}
