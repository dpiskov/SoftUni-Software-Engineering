namespace _01IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int add = firstNum + secondNum;
            double divide = add / thirdNum;
            double multiply = divide * fourthNum;

            Console.WriteLine(multiply);
        }
    }
}
