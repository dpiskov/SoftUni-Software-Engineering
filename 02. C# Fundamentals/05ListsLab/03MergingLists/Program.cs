namespace _03MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int length = 0;

            if (firstList.Count > secondList.Count)
            {
                length = firstList.Count;
            }
            else if (secondList.Count > firstList.Count)
            {
                length = secondList.Count;
            }

            for (int i = 0; i < length; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
