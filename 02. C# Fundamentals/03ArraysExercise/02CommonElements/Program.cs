namespace _02CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string common = string.Empty;

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        common += $"{firstArray[i]} ";
                    }
                }
            }

            Console.WriteLine(common.TrimEnd());
        }
    }
}
