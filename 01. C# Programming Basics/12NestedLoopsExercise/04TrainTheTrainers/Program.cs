namespace _04TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int presentationsCount = 0;

            double totalGrades = 0;

            while (input != "Finish")
            {
                presentationsCount++;

                double sumOfGrades = 0;

                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                }


                double averageGrade = sumOfGrades / n;
                totalGrades += averageGrade;
                Console.WriteLine($"{input} - {averageGrade:f2}.");

                input = Console.ReadLine();
            }

            double totalAverageGrade = totalGrades / presentationsCount;
            Console.WriteLine($"Student's final assessment is {totalAverageGrade:f2}.");
        }
    }
}