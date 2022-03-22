using System;
 
namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
 
            double result = 0;
 
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    result = 2.50;
                }
                else if (fruit == "apple")
                {
                    result = 1.20;
                }
                else if (fruit == "orange")
                {
                    result = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    result = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    result = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    result = 5.50;
                }
                else if (fruit == "grapes")
                {
                    result = 3.85;
                }
 
 
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    result = 2.70;
                }
                else if (fruit == "apple")
                {
                    result = 1.25;
                }
                else if (fruit == "orange")
                {
                    result = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    result = 1.60;
                }
                else if (fruit == "kiwi")
                {
                    result = 3.00;
                }
                else if (fruit == "pineapple")
                {
                    result = 5.60;
                }
                else if (fruit == "grapes")
                {
                    result = 4.20;
                }
 
            }
 
            if (result > 0)
            {
                Console.WriteLine($"{(result * qty):f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
 
        }
    }
}