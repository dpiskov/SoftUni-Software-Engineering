namespace _05Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fines
            // Facebook - 150
            // Instagram - 100
            // Reddit - 50

            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string page = Console.ReadLine();

                switch (page)
                {
                    case "Facebook": salary -= 150; break;
                    case "Instagram": salary -= 100; break;
                    case "Reddit": salary -= 50; break;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
