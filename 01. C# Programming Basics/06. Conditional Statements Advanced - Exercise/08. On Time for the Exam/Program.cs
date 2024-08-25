namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());

            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int totalExamMinutes = examHour * 60 + examMinutes;
            int totalArrivalMinutes = arriveHour * 60 + arriveMinutes;

            // On time
            if (totalArrivalMinutes - 30 >= totalExamMinutes && totalArrivalMinutes <= totalExamMinutes || totalArrivalMinutes == totalExamMinutes)
            {
                Console.WriteLine("On time");

                if (totalArrivalMinutes != totalExamMinutes)
                {
                    int difference = Math.Abs(totalArrivalMinutes - totalExamMinutes);
                    int minutes = difference % 60;

                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            // Early
            else if (totalArrivalMinutes - 30 <= totalExamMinutes)
            {
                int difference = Math.Abs(totalArrivalMinutes - totalExamMinutes);

                Console.WriteLine("Early");

                if (!(difference < 60))
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{difference:d2} minutes before the start");
                }

            }
        }
    }
}
