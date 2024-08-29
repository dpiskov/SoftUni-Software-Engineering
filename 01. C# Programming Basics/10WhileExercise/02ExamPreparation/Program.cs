namespace _02ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBadGrades = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int countOfBadGrades = 0;

            double totalGrades = 0;
            int gradesCount = 0;

            string lastProblem = string.Empty;

            while (input != "Enough")
            {
                string taskName = input;
                int grade = int.Parse(Console.ReadLine());

                lastProblem = input;

                gradesCount++;
                totalGrades += grade;

                if (grade <= 4)
                {
                    countOfBadGrades++;
                }

                if (countOfBadGrades == numberOfBadGrades)
                {
                    Console.WriteLine($"You need a break, {countOfBadGrades} poor grades.");
                    return;
                }

                input = Console.ReadLine();
            }

            double averageScore = totalGrades / gradesCount;

            Console.WriteLine($"Average score: {averageScore:f2}");
            Console.WriteLine($"Number of problems: {gradesCount}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
