namespace _06Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int roomsOnFloor = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                string floorAndRooms = string.Empty;

                if (i == floors)
                {
                    for (int j = 0; j < roomsOnFloor; j++)
                    {
                        floorAndRooms += $"L{i}{j} ";
                    }
                }
                else if (i % 2 == 0)
                {
                    for (int j = 0; j < roomsOnFloor; j++)
                    {
                        floorAndRooms += $"O{i}{j} ";
                    }
                }
                else if (i % 2 != 0)
                {
                    for (int j = 0; j < roomsOnFloor; j++)
                    {
                        floorAndRooms += $"A{i}{j} ";
                    }
                }

                Console.WriteLine(floorAndRooms.TrimEnd());
            }
        }
    }
}
