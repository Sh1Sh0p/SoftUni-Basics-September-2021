using System;
 
namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
 
            const double rosePrice = 5;
            const double dahliasPrice = 3.80;
            const double tulipsPrice = 2.80;
            const double narcissusPrice = 3;
            const double gladiolusPrice = 2.50;
 
 
 
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double finalyMoney = 0;
 
 
            switch (flowerType)
            {
                case "Roses":
                    if (flowerCount > 80)
                    {
                        finalyMoney -= flowerCount * rosePrice * 0.10;
                    }
                    finalyMoney += flowerCount * rosePrice;
                    break;
                case "Dahlias":
                    if (flowerCount > 90)
                    {
                        finalyMoney -= flowerCount * dahliasPrice * 0.15;
                    }
                    finalyMoney += flowerCount * dahliasPrice;
                    break;
                case "Tulips":
                    if (flowerCount > 80)
                    {
                        finalyMoney -= flowerCount * tulipsPrice * 0.15;
                    }
                    finalyMoney += flowerCount * tulipsPrice;
                    break;
                case "Narcissus":
                    if (flowerCount < 120)
                    {
                        finalyMoney += flowerCount * narcissusPrice * 0.15;
                    }
                    finalyMoney += flowerCount * narcissusPrice;
                    break;
                case "Gladiolus":
                    if (flowerCount < 80)
                    {
                        finalyMoney += flowerCount * gladiolusPrice * 0.20;
 
                    }
                    finalyMoney += flowerCount * gladiolusPrice;
                    break;
            }
            if (budget >= finalyMoney)
            {
                double moneyLeft = budget - finalyMoney;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {moneyLeft:f2} leva left.");
 
 
            }
            else
            {
                double moneyNeeded = finalyMoney - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
 
            }
 
 
 
        }
    }
}