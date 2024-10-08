﻿namespace _07Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if (age >= 0 && age <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    ticketPrice = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    ticketPrice = 18;
                }
                else if (typeOfDay == "Weekend")
                {
                    ticketPrice = 20;
                }
                else if (typeOfDay == "Holiday")
                {
                    ticketPrice = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    ticketPrice = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.WriteLine($"{ticketPrice}$");
        }
    }
}
