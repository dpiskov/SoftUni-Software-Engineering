namespace _11Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int times = int.Parse(Console.ReadLine());

            int i = times;

            do
            {
                int product = n * i;

                Console.WriteLine($"{n} X {i} = {product}");
                i++;
            } while (i <= 10);
        }
    }
}
