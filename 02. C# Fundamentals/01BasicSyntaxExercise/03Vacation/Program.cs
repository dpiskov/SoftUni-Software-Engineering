using System.Diagnostics;

namespace _03Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double priceForSinglePerson = 0;
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    priceForSinglePerson = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceForSinglePerson = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForSinglePerson = 10.46;
                }

                totalPrice = priceForSinglePerson * countOfPeople;

                if (countOfPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    priceForSinglePerson = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceForSinglePerson = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForSinglePerson = 16;
                }

                if (countOfPeople >= 100)
                {
                    totalPrice = priceForSinglePerson * (countOfPeople - 10);
                }
                else
                {
                    totalPrice = priceForSinglePerson * countOfPeople;
                }

            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    priceForSinglePerson = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceForSinglePerson = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForSinglePerson = 22.50;
                }

                totalPrice = priceForSinglePerson * countOfPeople;

                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    totalPrice *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
