namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishers = int.Parse(Console.ReadLine());

            // spring - 3000
            // summer + autumn - 4200
            // winter 2600

            // до 6 човека вкл. - 10% отстъпка
            // от 7 до 11 вкл - 15% отс.
            // от 12 нагоре - 25% отс

            //допълнителна отстъпка ако са четен брой освен ако не е есен - 5% отс.

            double boatPrice = 0;

            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
            }

            // Regular Discount
            if (numberOfFishers <= 6)
            {
                boatPrice *= 0.90;
            }
            else if (numberOfFishers >= 7 && numberOfFishers <= 11)
            {
                boatPrice *= 0.85;
            }
            else if (numberOfFishers >= 12)
            {
                boatPrice *= 0.75;
            }

            // Extra Discount
            if (numberOfFishers % 2 == 0 && season != "Autumn")
            {
                boatPrice *= 0.95;
            }

            if (boatPrice <= budget)
            {
                double moneyLeft = Math.Abs(boatPrice - budget);
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (boatPrice > budget)
            {
                double moneyNeeded = Math.Abs(boatPrice - budget);
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
