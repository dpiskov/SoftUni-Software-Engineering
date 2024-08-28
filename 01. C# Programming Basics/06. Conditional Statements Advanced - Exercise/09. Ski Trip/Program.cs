namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // room for one person - 18 per night
            // apartment - 25 per night
            // president apartment - 35 per night

            int daysStaying = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            int nights = daysStaying - 1;

            double pricePerNight = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    pricePerNight = 18;
                    break;
                case "apartment":
                    pricePerNight = 25;

                    if (daysStaying < 10)
                    {
                        pricePerNight *= 0.70;
                    }
                    else if (daysStaying >= 10 && daysStaying <= 15)
                    {
                        pricePerNight *= 0.65;
                    }
                    else if (daysStaying > 15)
                    {
                        pricePerNight *= 0.50;
                    }
                    break;
                case "president apartment":
                    pricePerNight = 35;

                    if (daysStaying < 10)
                    {
                        pricePerNight *= 0.90;
                    }
                    else if (daysStaying >= 10 && daysStaying <= 15)
                    {
                        pricePerNight *= 0.85;
                    }
                    else if (daysStaying > 15)
                    {
                        pricePerNight *= 0.80;
                    }
                    break;
            }

            double totalPrice = pricePerNight * nights;

            switch (rating)
            {
                case "positive":
                    totalPrice *= 1.25;
                    break;
                case "negative":
                    totalPrice *= 0.90;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}