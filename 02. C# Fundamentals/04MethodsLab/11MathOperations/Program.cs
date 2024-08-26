
namespace _11MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = PerformMathOperation(firstNum, @operator, secondNum);

            Console.WriteLine(result);
        }

        static double PerformMathOperation(int firstNum, string? @operator, int secondNum)
        {
            switch (@operator)
            {
                case "/": return firstNum / secondNum;
                case "*": return firstNum * secondNum;
                case "+": return firstNum + secondNum;
                default: return firstNum - secondNum;
            }
        }
    }
}
