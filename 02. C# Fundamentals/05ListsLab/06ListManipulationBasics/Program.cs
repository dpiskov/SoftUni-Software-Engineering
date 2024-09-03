namespace _06ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                if (command == "Add")
                {
                    int number = int.Parse(arguments[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(arguments[1]);
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(arguments[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(arguments[1]);
                    int index = int.Parse(arguments[2]);

                    numbers.Insert(index, number);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
