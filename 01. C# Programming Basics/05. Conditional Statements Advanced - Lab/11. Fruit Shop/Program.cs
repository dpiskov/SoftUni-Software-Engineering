namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            bool isExist = true;
            double fruitPrice = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana": fruitPrice = 2.50; break;
                        case "apple": fruitPrice = 1.20; break;
                        case "orange": fruitPrice = 0.85; break;
                        case "grapefruit": fruitPrice = 1.45; break;
                        case "kiwi": fruitPrice = 2.70; break;
                        case "pineapple": fruitPrice = 5.50; break;
                        case "grapes": fruitPrice = 3.85; break;
                        default: isExist = false; break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana": fruitPrice = 2.70; break;
                        case "apple": fruitPrice = 1.25; break;
                        case "orange": fruitPrice = 0.90; break;
                        case "grapefruit": fruitPrice = 1.60; break;
                        case "kiwi": fruitPrice = 3.00; break;
                        case "pineapple": fruitPrice = 5.60; break;
                        case "grapes": fruitPrice = 4.20; break;
                        default: isExist = false; ; break;
                    }
                    break;
                default: isExist = false; ; break;
            }

            if (!isExist)
            {
                Console.WriteLine("error");
                return;
            }

            double totalPrice = quantity * fruitPrice;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
