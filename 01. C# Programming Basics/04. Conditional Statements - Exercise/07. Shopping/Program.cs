namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double priceForGpu = 250;

            double budget = double.Parse(Console.ReadLine());
            int numberOfGpus = int.Parse(Console.ReadLine());
            int numberOfCpus = int.Parse(Console.ReadLine());
            int numberOfRam = int.Parse(Console.ReadLine());

            double totalGpuPrice = numberOfGpus * priceForGpu;
            double totalCpuPrice = numberOfCpus * (totalGpuPrice * 0.35);
            double totalRamPrice = numberOfRam * (totalGpuPrice * 0.10);

            double totalPrice = totalGpuPrice + totalCpuPrice + totalRamPrice;

            if (numberOfGpus > numberOfCpus)
            {
                totalPrice *= 0.85;
            }

            if (totalPrice <= budget)
            {
                double moneyLeft = Math.Abs(totalPrice - budget);
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else if (totalPrice > budget)
            {
                double moneyNeeded = Math.Abs(totalPrice - budget);
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
        }
    }
}
