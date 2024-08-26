
namespace _01SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            PrintSmallestNumber(firstNum, secondNum, thirdNum);
        }

        static void PrintSmallestNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (secondNum < thirdNum)
            {
                if (firstNum < secondNum)
                {
                    Console.WriteLine(firstNum);
                }
                else
                {
                    Console.WriteLine(secondNum);
                }
            }
            else
            {
                if (firstNum < thirdNum)
                {
                    Console.WriteLine(firstNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                }
            }
        }
    }
}
