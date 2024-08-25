namespace _07Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sumOfCoins = 0;

            while (input != "Start")
            {
                //valid coins - 0.1, 0.2, 0.5, 1, 2
                double coin = double.Parse(input);

                if (coin == 0.1)
                {
                    sumOfCoins += coin;
                }
                else if (coin == 0.2)
                {
                    sumOfCoins += coin;
                }
                else if (coin == 0.5)
                {
                    sumOfCoins += coin;
                }
                else if (coin == 1)
                {
                    sumOfCoins += coin;
                }
                else if (coin == 2)
                {
                    sumOfCoins += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            double priceForProduct = 0;

            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        priceForProduct = 2.0;

                        if (sumOfCoins >= priceForProduct)
                        {
                            Console.WriteLine($"Purchased nuts");
                            sumOfCoins -= priceForProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Water":
                        priceForProduct = 0.7;

                        if (sumOfCoins >= priceForProduct)
                        {
                            Console.WriteLine($"Purchased water");
                            sumOfCoins -= priceForProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumOfCoins -= priceForProduct;

                        }

                        break;
                    case "Crisps":
                        priceForProduct = 1.5;

                        if (sumOfCoins >= priceForProduct)
                        {
                            Console.WriteLine($"Purchased crisps");
                            sumOfCoins -= priceForProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Soda":
                        priceForProduct = 0.8;

                        if (sumOfCoins >= priceForProduct)
                        {
                            Console.WriteLine($"Purchased soda");
                            sumOfCoins -= priceForProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Coke":
                        priceForProduct = 1.0;

                        if (sumOfCoins >= priceForProduct)
                        {
                            Console.WriteLine($"Purchased coke");
                            sumOfCoins -= priceForProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    default: Console.WriteLine("Invalid product"); break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumOfCoins:f2}");
        }
    }
}