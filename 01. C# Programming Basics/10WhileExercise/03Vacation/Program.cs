namespace _03Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int spendingDays = 0;
            int totalDays = 0;

            while (true)
            {
                string typeOfAction = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                totalDays++;

                if (typeOfAction == "spend")
                {
                    spendingDays++;

                    if (money > availableMoney)
                    {
                        availableMoney = 0;
                    }
                    else
                    {
                        availableMoney -= money;
                    }

                    if (spendingDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{totalDays}");
                        return;
                    }
                }
                else if (typeOfAction == "save")
                {
                    spendingDays = 0;

                    availableMoney += money;

                    if (availableMoney >= moneyNeeded)
                    {
                        Console.WriteLine($"You saved the money for {totalDays} days.");
                        return;
                    }
                }
            }
        }
    }
}
