namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double resistance = Math.Floor(distanceInMeters / 15);
            double secondsSlowedDown = resistance * 12.5;

            double currentAttempt = distanceInMeters * secondsPerMeter;
            currentAttempt += secondsSlowedDown;

            if (currentAttempt < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {currentAttempt:f2} seconds.");
            }
            else if (currentAttempt >= recordInSeconds)
            {
                double secondsSlower = Math.Abs(currentAttempt - recordInSeconds);
                Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
            }
        }
    }
}
