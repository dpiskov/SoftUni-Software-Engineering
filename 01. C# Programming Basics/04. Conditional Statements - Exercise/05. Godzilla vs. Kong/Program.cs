namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double clothesPriceForExtra = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double totalClothesCost = numberOfExtras * clothesPriceForExtra;

            if (numberOfExtras > 150)
            {
                totalClothesCost *= 0.90;
            }

            double totalCost = decor + totalClothesCost;

            if (totalCost > budget)
            {
                double moneyNeeded = Math.Abs(budget - totalCost);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else if (totalCost <= budget)
            {
                double moneyLeft = Math.Abs(budget - totalCost);
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
