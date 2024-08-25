namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double chickenMenuPrice = 10.35;
            const double fishMenuPrice = 12.40;
            const double vegetarianMenuPrice = 8.15;

            // desert costs 20% of total cost
            // delivery costs 2.50lv and it's added at the end

            int numberOfChickenMenus = int.Parse(Console.ReadLine());
            int numberOfFishMenus = int.Parse(Console.ReadLine());
            int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

            double totalMenusCost = numberOfChickenMenus * chickenMenuPrice + numberOfFishMenus * fishMenuPrice + numberOfVegetarianMenus * vegetarianMenuPrice;
            double totalMenusAndDesertCost = totalMenusCost + (totalMenusCost * 0.2);
            double totalCostWithDelivery = totalMenusAndDesertCost + 2.50;

            Console.WriteLine(totalCostWithDelivery);
        }
    }
}
