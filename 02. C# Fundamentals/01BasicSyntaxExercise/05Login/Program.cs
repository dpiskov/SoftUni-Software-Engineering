namespace _05Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] passToChar = username.ToCharArray();

            string reverse = string.Empty;

            for (int i = passToChar.Length - 1; i >= 0; i--)
            {
                reverse += passToChar[i];
            }

            string input = Console.ReadLine();

            int attempt = 0;

            while (input != reverse)
            {
                attempt++;

                if (attempt == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");

                input = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
