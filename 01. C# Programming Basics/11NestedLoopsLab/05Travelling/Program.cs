namespace _05Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string destination = input;
                double minimalBudget = double.Parse(Console.ReadLine());

                double savedMoney = 0;

                while (savedMoney < minimalBudget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }

                if (savedMoney >= minimalBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
