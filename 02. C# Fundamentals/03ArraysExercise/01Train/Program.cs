namespace _01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] train = new int[n];

            int totalPassengers = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());

                train[i] = people;
                totalPassengers += people;
            }

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(totalPassengers);
        }
    }
}
