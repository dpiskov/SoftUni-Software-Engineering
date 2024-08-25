namespace _11Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double priceForCoffee = (days * capsulesCount) * pricePerCapsule;
                totalPrice += priceForCoffee;

                Console.WriteLine($"The price for the coffee is: ${priceForCoffee:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
