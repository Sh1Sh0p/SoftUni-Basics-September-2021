using System;
 
namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double totalPrice = 0;
 
 
            if (season == "Spring")
            {
                totalPrice = 3000;
 
                if (fishermen <= 6)
                {
                    totalPrice = totalPrice - (totalPrice * 0.1);
                }
                else if (6 < fishermen && fishermen <= 11)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
                else if (fishermen >= 12)
                {
                    totalPrice = totalPrice - (totalPrice * 0.25);
                }
            }
            else if (season == "Winter")
            {
                totalPrice = 2600;
 
                if (fishermen <= 6)
                {
                    totalPrice = totalPrice - (totalPrice * 0.1);
                }
                else if (6 < fishermen && fishermen <= 11)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
                else if (fishermen >= 12)
                {
                    totalPrice = totalPrice - (totalPrice * 0.25);
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                totalPrice = 4200;
 
                if (fishermen <= 6)
                {
                    totalPrice = totalPrice - (totalPrice * 0.1);
                }
                else if (6 < fishermen && fishermen <= 11)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
                else if (fishermen >= 12)
                {
                    totalPrice = totalPrice - (totalPrice * 0.25);
                }
            }
 
            if (season != "Autumn" && (fishermen % 2) == 0)
            {
                    totalPrice = totalPrice - (totalPrice * 0.05);
            }
 
 
            if (budget >= totalPrice)
            {
                    Console.WriteLine($"Yes! You have {(budget - totalPrice):f2} leva left.");
            }
            else if (totalPrice > budget)
            {
                    Console.WriteLine($"Not enough money! You need {(totalPrice - budget):f2} leva.");
            }
 
        }
    }
}