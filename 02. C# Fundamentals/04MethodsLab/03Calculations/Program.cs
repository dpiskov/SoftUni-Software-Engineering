

namespace _03Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int result = 0;

            if (operation == "add")
            {
                result = Add(firstNum, secondNum);
            }
            else if (operation == "multiply")
            {
                result = Multiply(firstNum, secondNum);
            }
            else if (operation == "subtract")
            {
                result = Subtract(firstNum, secondNum);
            }
            else if (operation == "divide")
            {
                result = Divide(firstNum, secondNum);
            }

            Console.WriteLine(result);
        }

        private static int Divide(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }

        private static int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        private static int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        private static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
