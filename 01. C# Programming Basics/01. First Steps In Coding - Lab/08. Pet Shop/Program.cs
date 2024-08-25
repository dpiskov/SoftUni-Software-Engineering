namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double dogFoodPrice = 2.50;
            const int catFoodPrice = 4;

            int numberOfDogFood = int.Parse(Console.ReadLine());
            int numberOfCatFood = int.Parse(Console.ReadLine());

            double totalPrice = numberOfDogFood * dogFoodPrice + numberOfCatFood * catFoodPrice;

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
