namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double talkingDollPrice = 3;
            const double teddyBearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2;

            double tripCost = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double totalToysCost = numberOfPuzzles * puzzlePrice + numberOfTalkingDolls * talkingDollPrice + numberOfTeddyBears * teddyBearPrice + numberOfMinions * minionPrice + numberOfTrucks * truckPrice;

            int totalNumberOfToys = numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;

            if (totalNumberOfToys >= 50)
            {
                totalToysCost *= 0.75;
            }

            // 10% go for rent
            totalToysCost *= 0.90;

            if (totalToysCost >= tripCost)
            {
                double moneyLeft = Math.Abs(totalToysCost - tripCost);
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else if (totalToysCost < tripCost)
            {
                double moneyNeeded = Math.Abs(totalToysCost - tripCost);
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
