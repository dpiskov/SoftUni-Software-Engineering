
namespace _08FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstFactorial = Factorial(firstNumber);
            double secondFactorial = Factorial(secondNumber);

            double division = firstFactorial / secondFactorial;

            Console.WriteLine($"{division:f2}");
        }

        static double Factorial(int number)
        {
            double factorial = 1;

            if (number != 1)
            {
                for (int i = number; i > 0; i--)
                {
                    factorial *= i;
                }
            }

            return factorial;
        }
    }
}
