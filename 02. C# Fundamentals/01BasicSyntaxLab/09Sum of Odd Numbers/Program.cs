﻿namespace _09Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            int number = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(number);
                sum += number;

                number += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
