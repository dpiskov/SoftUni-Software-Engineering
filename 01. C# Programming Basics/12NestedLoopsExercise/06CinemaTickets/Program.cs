namespace _06CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // student, standard, kid
            string input = Console.ReadLine();

            int student = 0;
            int standard = 0;
            int kid = 0;

            double totalTickets = 0;

            while (input != "Finish")
            {
                string movieName = input;
                int freeSeats = int.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();

                int freeSeatsCopy = freeSeats;
                double ticketsForMovie = 0;

                while (freeSeatsCopy >= 0 && ticket != "End")
                {
                    totalTickets++;
                    ticketsForMovie++;
                    freeSeatsCopy--;

                    if (ticket == "student")
                    {
                        student++;
                    }
                    else if (ticket == "standard")
                    {
                        standard++;
                    }
                    else if (ticket == "kid")
                    {
                        kid++;
                    }

                    if (freeSeatsCopy == 0)
                    {
                        break;
                    }

                    ticket = Console.ReadLine();
                }

                double fullness = (ticketsForMovie / freeSeats) * 100;

                Console.WriteLine($"{movieName} - {fullness:f2}% full.");

                input = Console.ReadLine();
            }

            double percentStudentTickets = (student / totalTickets) * 100;
            double percentStandardTickets = (standard / totalTickets) * 100;
            double percentKidTickets = (kid / totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{percentStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");
        }
    }
}
