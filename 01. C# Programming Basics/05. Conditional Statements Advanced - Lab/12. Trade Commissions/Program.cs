namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());

            bool isTrue = true;
            double commission = 0;

            if (town == "Sofia")
            {
                if (salesVolume < 0)
                {
                    isTrue = false;
                }
                else if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commission = 5;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commission = 7;
                }
                else if (salesVolume > 1000 && salesVolume <= 10_000)
                {
                    commission = 8;
                }
                else if (salesVolume > 10_000)
                {
                    commission = 12;
                }
            }
            else if (town == "Varna")
            {
                if (salesVolume < 0)
                {
                    isTrue = false;
                }
                else if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commission = 4.5;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commission = 7.5;
                }
                else if (salesVolume > 1000 && salesVolume <= 10_000)
                {
                    commission = 10;
                }
                else if (salesVolume > 10_000)
                {
                    commission = 13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (salesVolume < 0)
                {
                    isTrue = false;
                }
                else if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commission = 5.5;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commission = 8;
                }
                else if (salesVolume > 1000 && salesVolume <= 10_000)
                {
                    commission = 12;
                }
                else if (salesVolume > 10_000)
                {
                    commission = 14.5;
                }
            }
            else
            {
                    isTrue = false;
            }

            if (!isTrue)
            {
                Console.WriteLine("error");
                return;
            }

            double result = salesVolume * (commission / 100);
            Console.WriteLine($"{result:f2}");
        }
    }
}
