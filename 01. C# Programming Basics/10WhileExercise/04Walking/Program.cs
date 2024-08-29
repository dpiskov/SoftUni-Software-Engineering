namespace _04Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int totalSteps = 0;

            while (input != "Going home")
            {
                int walkedSteps = int.Parse(input);
                totalSteps += walkedSteps;

                if (totalSteps > 10_000)
                {
                    int difference = Math.Abs(10_000 - totalSteps);
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{difference} steps over the goal!");
                    return;
                }
                else if (totalSteps == 10_000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    return;
                }

                input = Console.ReadLine();
            }

            int stepsWalkingHome = int.Parse(Console.ReadLine());

            totalSteps += stepsWalkingHome;

            if (totalSteps > 10_000)
            {
                int difference = Math.Abs(10_000 - totalSteps);
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
                return;
            }
            else if (totalSteps == 10_000)
            {
                Console.WriteLine("Goal reached! Good job!");
                return;
            }
            else if (totalSteps < 10_000)
            {
                int stepsNeeded = Math.Abs(10_000 - totalSteps);
                Console.WriteLine($"{stepsNeeded} more steps to reach goal.");
            }
        }
    }
}
