﻿namespace _05PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = start; i <= end; i++)
            {
                result += (char)i + " ";
            }

            Console.WriteLine(result.TrimEnd());
        }
    }
}
