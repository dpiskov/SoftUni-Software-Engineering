namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // summer - camp
            // winter - hotel
            // Europe - always Hotel, season doesn't matter

            string destination = string.Empty;
            string typeOfHoliday = string.Empty;

            double costOfHoliday = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                switch (season)
                {
                    case "summer":
                        typeOfHoliday = "Camp";
                        costOfHoliday = budget * 0.30;
                        break;
                    case "winter":
                        typeOfHoliday = "Hotel";
                        costOfHoliday = budget * 0.70;
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                switch (season)
                {
                    case "summer":
                        typeOfHoliday = "Camp";
                        costOfHoliday = budget * 0.40;
                        break;
                    case "winter":
                        typeOfHoliday = "Hotel";
                        costOfHoliday = budget * 0.80;
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeOfHoliday = "Hotel";
                costOfHoliday = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHoliday} - {costOfHoliday:f2}");
        }
    }
}
