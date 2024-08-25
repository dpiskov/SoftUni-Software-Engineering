namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;

            double capacityOfAquarium = length * width * height;
            double capacityInLitres = capacityOfAquarium / 1000;
            double neededLitres = capacityInLitres * (1 - percent);

            Console.WriteLine(neededLitres);
        }
    }
}
