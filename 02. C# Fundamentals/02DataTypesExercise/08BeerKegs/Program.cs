namespace _08BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> kegVolume = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                double volume = 0;

                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * (radius * radius) * height;

                kegVolume.Add(model, volume);
            }

            double maxValue = double.MinValue;
            string beerKeg = string.Empty;

            foreach (var item in kegVolume)
            {
                if (item.Value > maxValue)
                {
                    beerKeg = item.Key;
                    maxValue = item.Value;
                }
            }

            Console.WriteLine(beerKeg);
        }
    }
}
