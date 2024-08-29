namespace _01OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string input = Console.ReadLine();

            int bookCount = 0;

            while (input != "No More Books")
            {

                if (book == input)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    return;
                }

                bookCount++;
                input = Console.ReadLine();
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {bookCount} books.");
        }
    }
}
