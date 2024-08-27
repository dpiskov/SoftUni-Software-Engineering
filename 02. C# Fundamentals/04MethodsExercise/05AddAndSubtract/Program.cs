
namespace _05AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = SumOfFirstTwoIntegers(firstNum, secondNum);
            int subtraction = SutractThirdIntegerFromResult(thirdNum, sum);

            Console.WriteLine(subtraction);
        }

        static int SumOfFirstTwoIntegers(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static int SutractThirdIntegerFromResult(int thirdNum, int sum)
        {
            return sum - thirdNum;
        }
    }
}
