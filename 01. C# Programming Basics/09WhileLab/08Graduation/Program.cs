namespace _08Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            int grade = 0;
            int failedGrades = 0;

            double totalGrades = 0;

            while (grade < 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());

                if (yearlyGrade >= 4.00)
                {
                    totalGrades += yearlyGrade;
                }
                else if (yearlyGrade < 4.00)
                {
                    failedGrades++;

                    if (failedGrades > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grade} grade");
                        return;
                    }
                }

                grade++;
            }

            double averageGrades = totalGrades / grade;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrades:f2}");
        }
    }
}