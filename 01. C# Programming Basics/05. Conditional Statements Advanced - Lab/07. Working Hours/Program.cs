namespace _07._Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (hours >= 10 && hours <= 18)
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    default: Console.WriteLine("closed"); break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}