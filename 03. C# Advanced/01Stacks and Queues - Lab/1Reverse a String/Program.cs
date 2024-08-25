namespace _1Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            foreach (char c in input)
            {
                stack.Push(c.ToString());
            }

            string reversed = string.Empty;

            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            Console.WriteLine(string.Join("", reversed));
        }
    }
}
