namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double priceForPensPackage = 5.80;
            const double priceForMarkersPackage = 7.20;
            const double priceForAbstergentPerLiter = 1.20;

            int numberOfPens = int.Parse(Console.ReadLine());
            int numberOfMarkers = int.Parse(Console.ReadLine());
            int litersOfAbstergent = int.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine()) / 100;

            double totalSum = numberOfPens * priceForPensPackage + numberOfMarkers * priceForMarkersPackage + litersOfAbstergent * priceForAbstergentPerLiter;

            double totalSumAfterDiscount = totalSum - (totalSum * discountPercentage);

            Console.WriteLine(totalSumAfterDiscount);
        }
    }
}
