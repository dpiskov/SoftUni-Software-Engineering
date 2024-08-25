namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pricePerSquareMeter = 7.61;
            const double discountOfTotalPrice = 0.18; // 18 percent discount

            double squareMetersForGreening = double.Parse(Console.ReadLine());

            double finalPrice = squareMetersForGreening * pricePerSquareMeter;
            double discount = finalPrice * discountOfTotalPrice;

            finalPrice -= discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
