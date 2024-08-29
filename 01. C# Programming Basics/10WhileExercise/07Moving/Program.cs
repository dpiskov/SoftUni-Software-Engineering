namespace _07Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int totalSpace = width * length * height;

            string input = Console.ReadLine();

            int totalBoxes = 0;

            while (input != "Done")
            {
                int boxes = int.Parse(input);

                totalBoxes += boxes;

                if (totalBoxes >= totalSpace)
                {
                    int cubicMetersNeeded = Math.Abs(totalBoxes - totalSpace);
                    Console.WriteLine($"No more free space! You need {cubicMetersNeeded} Cubic meters more.");
                    return;
                }

                input = Console.ReadLine();
            }

            int cubicMetersLeft = Math.Abs(totalBoxes - totalSpace);
            Console.WriteLine($"{cubicMetersLeft} Cubic meters left.");
        }
    }
}
