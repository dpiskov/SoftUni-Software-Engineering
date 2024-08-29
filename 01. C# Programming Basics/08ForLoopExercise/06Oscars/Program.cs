namespace _06Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double totalPoints = pointsFromAcademy;

            for (int i = 0; i < n; i++)
            {
                string raterName = Console.ReadLine();
                double raterPoints = double.Parse(Console.ReadLine());

                totalPoints += raterName.Length * (raterPoints / 2);

                if (totalPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }
            }

            double pointsNeeded = 1250.5 - totalPoints;
            Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
        }
    }
}
