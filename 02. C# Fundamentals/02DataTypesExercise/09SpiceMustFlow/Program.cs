namespace _09SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalYield = 0;

            // Starting yield = yield that can be mined for the day
            // Every day the yield drops down by 10.
            // When the yield goes under 100 abandon the mine.
            // The workers consume 26 at the end of their shift
            // The workers consume additional 26 after the mine has been exhausted

            int days = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalYield);
            }
            else
            {
                while (startingYield >= 100)
                {
                    totalYield += startingYield - 26;
                    startingYield -= 10;
                    days++;
                }

                totalYield -= 26;

                Console.WriteLine(days);
                Console.WriteLine(totalYield);
            }

        }
    }
}
