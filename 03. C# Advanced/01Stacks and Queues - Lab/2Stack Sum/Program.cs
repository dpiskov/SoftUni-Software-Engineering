namespace _2Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0].ToLower();

                if (command == "add")
                {
                    int firstNum = int.Parse(cmdArgs[1]);
                    int secondNum = int.Parse(cmdArgs[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (command == "remove")
                {
                    int count = int.Parse(cmdArgs[1]);

                    if (count > stack.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                input = Console.ReadLine();
            }

            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}