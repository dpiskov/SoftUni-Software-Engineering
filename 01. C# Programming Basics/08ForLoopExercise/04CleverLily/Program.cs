namespace _04CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int singleToyPrice = int.Parse(Console.ReadLine());

            int money = 10;
            int savedMoney = 0;
            int toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += money;
                    savedMoney--;
                    money += 10;
                }
                else if (i % 2 != 0)
                {
                    toys++;
                }
            }

            int totalToysPrice = toys * singleToyPrice;
            savedMoney += totalToysPrice;

            if (savedMoney >= washingMachinePrice)
            {
                double moneyLeft = Math.Abs(savedMoney - washingMachinePrice);
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else if (savedMoney < washingMachinePrice)
            {
                double moneyNeeded = Math.Abs(savedMoney - washingMachinePrice);
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
