namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowerPrice = 0;
            double discount = 0;
            double priceIncrease = 0;

            switch (typeOfFlowers)
            {
                case "Roses":
                    if (numberOfFlowers > 80)
                    {
                        discount = 0.10;
                    }
                    flowerPrice = 5;
                    break;
                case "Dahlias":
                    if (numberOfFlowers > 90)
                    {
                        discount = 0.15;
                    }
                    flowerPrice = 3.80;
                    break;
                case "Tulips":
                    if (numberOfFlowers > 80)
                    {
                        discount = 0.15;
                    }
                    flowerPrice = 2.80;
                    break;
                case "Narcissus":
                    if (numberOfFlowers < 120)
                    {
                        priceIncrease = 0.15;
                    }
                    flowerPrice = 3;
                    break;
                case "Gladiolus":
                    if (numberOfFlowers < 80)
                    {
                        priceIncrease = 0.20;
                    }
                    flowerPrice = 2.50;
                    break;
            }

            double totalCost = numberOfFlowers * flowerPrice;

            if (discount != 0)
            {
                totalCost *= 1 - discount;
            }
            else if (priceIncrease != 0)
            {
                totalCost *= 1 + priceIncrease;
            }

            if (totalCost <= budget)
            {
                double moneyLeft = Math.Abs(totalCost - budget);
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {moneyLeft:f2} leva left.");
            }
            else if (totalCost > budget)
            {
                double moneyNeeded = Math.Abs(totalCost - budget);
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
