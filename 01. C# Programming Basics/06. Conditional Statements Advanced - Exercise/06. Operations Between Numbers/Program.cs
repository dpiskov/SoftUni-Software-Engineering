namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());

            double result = 0;

            switch (@operator)
            {
                case '+':
                    result = firstNum + secondNum;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNum} + {secondNum} = {result} - even");
                    }
                    else if (result % 2 != 0)
                    {
                        Console.WriteLine($"{firstNum} + {secondNum} = {result} - odd");
                    }

                    break;
                case '-':
                    result = firstNum - secondNum;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNum} - {secondNum} = {result} - even");
                    }
                    else if (result % 2 != 0)
                    {
                        Console.WriteLine($"{firstNum} - {secondNum} = {result} - odd");
                    }

                    break;
                case '*':
                    result = firstNum * secondNum;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNum} * {secondNum} = {result} - even");
                    }
                    else if (result % 2 != 0)
                    {
                        Console.WriteLine($"{firstNum} * {secondNum} = {result} - odd");
                    }

                    break;
                case '/':
                    if (firstNum == 0)
                    {
                        Console.WriteLine($"Cannot divide {secondNum} by zero");
                        return;
                    }
                    else if (secondNum == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNum} by zero");
                        return;
                    }

                    result = firstNum / (double)secondNum;

                    Console.WriteLine($"{firstNum} / {secondNum} = {result:f2}");

                    break;
                case '%':
                    if (firstNum == 0)
                    {
                        Console.WriteLine($"Cannot divide {secondNum} by zero");
                        return;
                    }
                    else if (secondNum == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNum} by zero");
                        return;
                    }

                    result = firstNum % secondNum;

                    Console.WriteLine($"{firstNum} % {secondNum} = {result}");

                    break;
            }
        }
    }
}
