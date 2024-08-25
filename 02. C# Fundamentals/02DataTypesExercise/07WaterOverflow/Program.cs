namespace _07WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tankCapacity = 255;

            int n = int.Parse(Console.ReadLine());

            int capacity = 0;

            for (int i = 0; i < n; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());

                if (capacity + litersOfWater <= tankCapacity)
                {
                    capacity += litersOfWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(capacity);
        }
    }
}
