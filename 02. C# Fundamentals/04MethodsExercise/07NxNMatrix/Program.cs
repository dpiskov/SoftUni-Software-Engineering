
namespace _07NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNxNMatrix(n);
        }

        private static void PrintNxNMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string line = string.Empty;

                for (int j = 0; j < n; j++)
                {
                    line += n + " ";
                }

                Console.WriteLine(line.TrimEnd());
            }
        }
    }
}
