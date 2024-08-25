namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // formula - сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

            double depositSum = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine()) / 100;

            double totalSum = depositSum + termOfDeposit * ((depositSum * annualInterestRate) / 12);

            Console.WriteLine(totalSum);
        }
    }
}
