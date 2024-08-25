using System.Text;

namespace _08Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                string row = string.Empty;

                for (int j = 0; j < i; j++)
                {
                    row += i + " ";
                }

                sb.AppendLine(row.TrimEnd());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
