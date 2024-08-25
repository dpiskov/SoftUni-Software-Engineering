namespace _10Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    headsetCount++;
                    mouseCount++;
                    keyboardCount++;

                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
                else if (i % 2 == 0)
                {
                    headsetCount++;
                }
                else if (i % 3 == 0)
                {
                    mouseCount++;
                }
            }

            double totalExpenses = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
