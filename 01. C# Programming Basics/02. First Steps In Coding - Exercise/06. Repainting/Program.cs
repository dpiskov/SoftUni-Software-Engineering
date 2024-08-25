namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double nylonPricePerSquareMeter = 1.50;
            const double paintPricePerLiter = 14.50;
            const double paintDiluentPricePerLiter = 5.00;

            int nylon = int.Parse(Console.ReadLine()) + 2;
            double paint = double.Parse(Console.ReadLine()) * 1.10;
            int diluent = int.Parse(Console.ReadLine());
            int hoursToFinishWork = int.Parse(Console.ReadLine());


            double totalMaterialsCost = nylon * nylonPricePerSquareMeter + paint * paintPricePerLiter + diluent * paintDiluentPricePerLiter + 0.40;

            double workersCost = (totalMaterialsCost * 0.30) * hoursToFinishWork;

            double totalCost = totalMaterialsCost + workersCost;

            Console.WriteLine(totalCost);
        }
    }
}
