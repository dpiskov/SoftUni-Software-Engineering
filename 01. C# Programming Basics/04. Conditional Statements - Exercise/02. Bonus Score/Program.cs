namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (startingPoints <= 100)
            {
                bonusPoints += 5;
            }
            if (startingPoints > 100)
            {
                bonusPoints = startingPoints * 0.20;
            }
            if (startingPoints > 1000)
            {
                bonusPoints = startingPoints * 0.10;
            }

            if (startingPoints % 2 == 0)
            {
                bonusPoints += 1;
            }
            if (startingPoints % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(startingPoints + bonusPoints);
        }
    }
}
