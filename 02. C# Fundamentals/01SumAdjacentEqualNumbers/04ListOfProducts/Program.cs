namespace _04ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();

                products.Add(product);
            }

            int count = 1;

            foreach (string product in products.OrderBy(p => p))
            {
                Console.WriteLine($"{count}.{product}");
                count++;
            }
        }
    }
}
