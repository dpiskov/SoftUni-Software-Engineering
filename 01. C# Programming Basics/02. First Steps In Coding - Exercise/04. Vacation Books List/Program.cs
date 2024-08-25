namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int daysToFinishBook = int.Parse(Console.ReadLine());

            int totalHours = numberOfPages / pagesReadPerHour;
            int hoursPerDay = totalHours / daysToFinishBook;

            Console.WriteLine(hoursPerDay);
        }
    }
}
