namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // square / rectangle / circle / triangle
            string figure = Console.ReadLine();
            double result = 0;

            if (figure == "square")
            {
                double length = double.Parse(Console.ReadLine());
                result = length * length;
            }
            else if (figure == "rectangle")
            {
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());
                result = firstNum * secondNum;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = radius * radius * Math.PI;
            }
            else if (figure == "triangle")
            {
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());
                result = (firstNum * secondNum) / 2;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
