namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int hoursToFinishAProject = 3;

            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());

            int totalHours = numberOfProjects * hoursToFinishAProject;

            Console.WriteLine($"The architect {architectName} will need {totalHours} hours to complete {numberOfProjects} project/s.");
        }
    }
}
