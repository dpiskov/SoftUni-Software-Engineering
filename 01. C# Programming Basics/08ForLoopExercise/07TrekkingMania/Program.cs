namespace _07TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroupsOfClimbers = int.Parse(Console.ReadLine());

            int totalPeople = 0;

            double mussala = 0;
            double monblan = 0;
            double killimanjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 0; i < numberOfGroupsOfClimbers; i++)
            {
                int numberOfPeopleInAGroup = int.Parse(Console.ReadLine());

                totalPeople += numberOfPeopleInAGroup;

                if (numberOfPeopleInAGroup <= 5)
                {
                    mussala += numberOfPeopleInAGroup;
                }
                else if (numberOfPeopleInAGroup <= 12)
                {
                    monblan += numberOfPeopleInAGroup;
                }
                else if (numberOfPeopleInAGroup <= 25)
                {
                    killimanjaro += numberOfPeopleInAGroup;
                }
                else if (numberOfPeopleInAGroup <= 40)
                {
                    k2 += numberOfPeopleInAGroup;
                }
                else if (numberOfPeopleInAGroup >= 41)
                {
                    everest += numberOfPeopleInAGroup;
                }
            }

            Console.WriteLine($"{(mussala / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(monblan / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(killimanjaro / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(k2 / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(everest / totalPeople) * 100:f2}%");
        }
    }
}
