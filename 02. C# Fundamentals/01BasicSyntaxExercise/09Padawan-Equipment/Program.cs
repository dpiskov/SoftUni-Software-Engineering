namespace _09Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            //lightsabers
            double moreLightsabers = Math.Ceiling(countOfStudents * 1.10);

            //belts
            double beltCount = countOfStudents / 6;

            double totalLightsabersPrice = moreLightsabers * lightsaberPrice;
            double totalRobesPrice = countOfStudents * robePrice;
            double totalBeltsPrice = (countOfStudents - beltCount) * beltPrice;

            double totalCost = totalLightsabersPrice + totalRobesPrice + totalBeltsPrice;

            if (totalCost <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else if (totalCost > amountOfMoney)
            {
                double moneyNeeded = Math.Abs(totalCost - amountOfMoney);
                Console.WriteLine($"John will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
