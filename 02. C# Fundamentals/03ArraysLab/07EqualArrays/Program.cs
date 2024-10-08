﻿namespace _07EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    oddSum += numbers[i];
                }
            }

            int difference = evenSum - oddSum;

            Console.WriteLine(difference);
        }
    }
}
