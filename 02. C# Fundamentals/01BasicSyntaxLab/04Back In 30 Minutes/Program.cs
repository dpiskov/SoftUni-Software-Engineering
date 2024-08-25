namespace _04Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes + 30;

            int newHours = totalMinutes / 60;
            int newMinutes = totalMinutes % 60;

            if (newHours > 23)
            {
                newHours -= 24;
            }
            if (newMinutes > 59)
            {
                newMinutes -= 60;
            }

            Console.WriteLine($"{newHours}:{newMinutes:d2}");
        }
    }
}
