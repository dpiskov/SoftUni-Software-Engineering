namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tvShowName = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int lunchBreakLength = int.Parse(Console.ReadLine());

            double timeToEat = lunchBreakLength / 8.0;
            double timeToRelax = lunchBreakLength / 4.0;

            double freeTimeLeft = lunchBreakLength - (timeToEat + timeToRelax);

            if (freeTimeLeft >= episodeLength)
            {
                double timeLeft = Math.Ceiling(freeTimeLeft - episodeLength);

                Console.WriteLine($"You have enough time to watch {tvShowName} and left with {timeLeft} minutes free time.");
            }
            else
            {
                double timeNeeded = Math.Ceiling(episodeLength - freeTimeLeft);
                Console.WriteLine($"You don't have enough time to watch {tvShowName}, you need {timeNeeded} more minutes.");
            }
        }
    }
}
