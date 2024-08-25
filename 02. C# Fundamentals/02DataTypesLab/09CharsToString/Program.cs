namespace _09CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondsChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            string charToString = $"{firstChar}{secondsChar}{thirdChar}";

            Console.WriteLine(charToString);
        }
    }
}
