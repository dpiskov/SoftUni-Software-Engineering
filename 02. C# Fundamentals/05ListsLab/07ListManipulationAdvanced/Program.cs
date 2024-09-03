namespace _07ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                if (command == "Contains")
                {
                    double number = double.Parse(arguments[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else if (!numbers.Contains(number))
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    string evenNumbers = string.Empty;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNumbers += $"{numbers[i]} ";
                        }
                    }

                    Console.WriteLine(evenNumbers.TrimEnd());
                }
                else if (command == "PrintOdd")
                {
                    string oddNumbers = string.Empty;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            oddNumbers += $"{numbers[i]} ";
                        }
                    }

                    Console.WriteLine(oddNumbers.TrimEnd());
                }
                else if (command == "GetSum")
                {
                    double sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                }
                else if (command == "Filter")
                {
                    string condition = arguments[1];
                    double number = double.Parse(arguments[2]);

                    List<double> filteredList = new List<double>();

                    switch (condition)
                    {
                        case "<":
                            filteredList = numbers.Where(n => n < number).ToList();
                            break;
                        case ">":
                            filteredList = numbers.Where(n => n > number).ToList();
                            break;
                        case ">=":
                            filteredList = numbers.Where(n => n >= number).ToList();
                            break;
                        case "<=":
                            filteredList = numbers.Where(n => n <= number).ToList();
                            break;
                    }

                    Console.WriteLine(string.Join(" ", filteredList));
                }

                input = Console.ReadLine();
            }
        }
    }
}
