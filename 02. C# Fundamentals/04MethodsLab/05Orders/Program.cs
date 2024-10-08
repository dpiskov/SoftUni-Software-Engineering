﻿
namespace _05Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateAndPrintTotalSum(product, quantity);
        }

        static void CalculateAndPrintTotalSum(string? product, int quantity)
        {
            double productPrice = 0;

            switch (product)
            {
                case "coffee": productPrice = 1.50; break;
                case "water": productPrice = 1.00; break;
                case "coke": productPrice = 1.40; break;
                case "snacks": productPrice = 2.00; break;
            }

            double totalSum = quantity * productPrice;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
