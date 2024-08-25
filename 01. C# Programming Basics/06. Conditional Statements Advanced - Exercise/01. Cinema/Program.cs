namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double premierePrice = 12.00;
            const double normalPrice = 7.50;
            const double discountPrice = 5.00;

            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            switch (projection)
            {
                case "Premiere":
                    totalPrice = premierePrice * rows * cols; 
                    break;
                case "Normal":
                    totalPrice = normalPrice * rows * cols;
                    break;
                case "Discount":
                    totalPrice = discountPrice * rows * cols;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2} leva");
        }
    }
}
