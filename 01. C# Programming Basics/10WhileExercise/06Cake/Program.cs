namespace _06Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int totalCakePieces = width * length;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int guestPieces = int.Parse(input);

                if (totalCakePieces - guestPieces >= 0)
                {
                    totalCakePieces -= guestPieces;
                }
                else if (totalCakePieces - guestPieces < 0)
                {
                    int piecesNeeded = Math.Abs(totalCakePieces - guestPieces);
                    Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{totalCakePieces} pieces are left.");
        }
    }
}
