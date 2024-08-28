namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // studio
            // apartment

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPricePerNight = 0;
            double apartmentPricePerNight = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPricePerNight = 50;
                    apartmentPricePerNight = 65;

                    if (nights > 14)
                    {
                        studioPricePerNight *= 0.70;
                    }
                    else if (nights > 7)
                    {
                        studioPricePerNight *= 0.95;
                    }

                    break;
                case "June":
                case "September":
                    studioPricePerNight = 75.20;
                    apartmentPricePerNight = 68.70;

                    if (nights > 14)
                    {
                        studioPricePerNight *= 0.80;
                    }

                    break;

                case "July":
                case "August":
                    studioPricePerNight = 76;
                    apartmentPricePerNight = 77;
                    break;
            }

            if (nights > 14)
            {
                apartmentPricePerNight *= 0.90;
            }

            double totalStudioPrice = studioPricePerNight * nights;
            double totalApartmentPrice = apartmentPricePerNight * nights;

            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
