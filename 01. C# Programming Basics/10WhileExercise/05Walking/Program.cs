﻿namespace _05Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine()) * 100;

            int coinsCount = 0;

            while (change > 0)
            {
                if (change - 200 >= 0)
                {
                    change -= 200;
                    coinsCount++;
                }
                else if (change - 100 >= 0)
                {
                    change -= 100;
                    coinsCount++;
                }
                else if (change - 50 >= 0)
                {
                    change -= 50;
                    coinsCount++;
                }
                else if (change - 20 >= 0)
                {
                    change -= 20;
                    coinsCount++;
                }
                else if (change - 10 >= 0)
                {
                    change -= 10;
                    coinsCount++;
                }
                else if (change - 5 >= 0)
                {
                    change -= 5;
                    coinsCount++;
                }
                else if (change - 2 >= 0)
                {
                    change -= 2;
                    coinsCount++;
                }
                else if (change - 1 >= 0)
                {
                    change -= 1;
                    coinsCount++;
                }
            }

            Console.WriteLine(coinsCount);
        }
    }
}
