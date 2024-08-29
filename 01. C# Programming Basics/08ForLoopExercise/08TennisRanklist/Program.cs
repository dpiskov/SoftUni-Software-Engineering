namespace _08TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int earnedPoints = 0;
            double wonTournaments = 0;

            for (int i = 0; i < tournamentsCount; i++)
            {
                string stage = Console.ReadLine(); // W, F, SF

                switch (stage)
                {
                    case "W":
                        earnedPoints += 2000;
                        wonTournaments++;
                        break;
                    case "F": earnedPoints += 1200; break;
                    case "SF": earnedPoints += 720; break;
                }
            }

            int finalPoints = startingPoints + earnedPoints;
            double averagePoints = earnedPoints / tournamentsCount;
            averagePoints = Math.Round(averagePoints, MidpointRounding.ToZero);
            double percentWonTournaments = (wonTournaments / tournamentsCount) * 100;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWonTournaments:f2}%");
        }
    }
}
