using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double qty = double.Parse(Console.ReadLine());

            double result = 0;

            if (city == "varna")
            {
                if (product == "coffee")
                {
                    result = 0.45;
                }
                else if (product == "water")
                {
                    result = 0.70;
                }
                else if (product == "beer")
                {
                    result = 1.10;
                }
                else if (product == "sweets")
                {
                    result = 1.35;
                }
                else if (product == "peanuts")
                {
                    result = 1.55;
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    result = 0.40;
                }
                else if (product == "water")
                {
                    result = 0.70;
                }
                else if (product == "beer")
                {
                    result = 1.15;
                }
                else if (product == "sweets")
                {
                    result = 1.30;
                }
                else if (product == "peanuts")
                {
                    result = 1.50;
                }

            }
            else if (city == "sofia")
            {
                if (product == "coffee")
                {
                    result = 0.50;
                }
                else if (product == "water")
                {
                    result = 0.80;
                }
                else if (product == "beer")
                {
                    result = 1.20;
                }
                else if (product == "sweets")
                {
                    result = 1.45;
                }
                else if (product == "peanuts")
                {
                    result = 1.60;
                }
            }
            Console.WriteLine(result * qty);
        }
    }
}