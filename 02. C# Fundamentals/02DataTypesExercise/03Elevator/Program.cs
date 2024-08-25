namespace _03Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = numberOfPeople / capacity;
            int peopleLeft = 0;

            if (numberOfPeople % capacity != 0)
            {
                peopleLeft = numberOfPeople % capacity;
            }

            if (peopleLeft > 0 && peopleLeft <= capacity)
            {
                fullCourses++;
            }

            Console.WriteLine(fullCourses);
        }
    }
}
