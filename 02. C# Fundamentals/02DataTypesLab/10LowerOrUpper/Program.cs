namespace _10LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            if (Char.IsUpper(character))
            {
                Console.WriteLine("upper-case");
            }
            else if (Char.IsLower(character))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
