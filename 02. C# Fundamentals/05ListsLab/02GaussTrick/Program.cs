namespace _02GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> list = new List<double>();

            for (int i = 0; i <= numbers.Count / 2; i++)
            {
                double firstNumber;
                double secondNumber;

                firstNumber = numbers[i];
                secondNumber = numbers[numbers.Count - 1];

                numbers[i] += secondNumber;
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
