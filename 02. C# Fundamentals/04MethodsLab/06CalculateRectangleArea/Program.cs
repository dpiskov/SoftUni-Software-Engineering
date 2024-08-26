
namespace _06CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int result = CalculateAreaOfRectangle(width, height);

            Console.WriteLine(result);
        }

        static int CalculateAreaOfRectangle(int width, int height)
        {
            int area = width * height;

            return area;
        }
    }
}
