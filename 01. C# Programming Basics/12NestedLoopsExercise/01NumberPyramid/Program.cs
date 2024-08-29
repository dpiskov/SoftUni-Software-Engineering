namespace _01NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                string row = string.Empty;

                for (int j = i; j <= n - i; j++)
                {
                    row += $"{j} ";
                }

                Console.WriteLine(row);
            }
        }
    }
}
