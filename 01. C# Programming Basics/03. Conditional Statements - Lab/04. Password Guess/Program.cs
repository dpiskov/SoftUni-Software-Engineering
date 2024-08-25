namespace _04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string password = "s3cr3t!P@ssw0rd";

            string input = Console.ReadLine();

            if (password == input)
            {
                Console.WriteLine("Welcome");
            } else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
