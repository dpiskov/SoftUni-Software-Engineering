﻿namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyBasketballTrainingCost = int.Parse(Console.ReadLine());

            double sneakers = yearlyBasketballTrainingCost * 0.60;
            double outfit = sneakers * 0.80;
            double ball = outfit / 4;
            double accessories = ball / 5;

            double totalCost = yearlyBasketballTrainingCost + sneakers + outfit + ball + accessories;

            Console.WriteLine(totalCost);
        }
    }
}
