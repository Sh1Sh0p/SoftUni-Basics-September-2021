using System;
 
namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mayAndOctomberStudioPrice = 50;
            const double mayAndOctomberApartamentPrice = 65;
            const double juneAndSeptemberStudioPrice = 75.20;
            const double juneAndSeptemberApartamentPrice = 68.70;
            const double julyAndAugustStudioPrice = 76;
            const double julyAndAugustApartamentPrice = 77;
 
            string season = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double totalMoneyForStudio = 0;
            double totalMoneyForApartment = 0;
 
            switch (season)
            {
                case "May":
                case "October":
                    totalMoneyForStudio = nights * mayAndOctomberStudioPrice;
                    totalMoneyForApartment = nights * mayAndOctomberApartamentPrice;
 
                    if (nights > 7 && nights <= 14)
                    {
                        totalMoneyForStudio -= totalMoneyForStudio * 0.05;
                    }
                    else if (nights > 14)
                    {
                        totalMoneyForStudio -= totalMoneyForStudio * 0.3;
                    }
                    break;
 
                case "June":
                case "September":
                    totalMoneyForStudio = nights * juneAndSeptemberStudioPrice;
                    totalMoneyForApartment = nights * juneAndSeptemberApartamentPrice;
                    if (nights > 14)
                    {
                        totalMoneyForStudio -= totalMoneyForStudio * 0.20;
 
                    }
                    break;
                case "July":
                case "August":
                    totalMoneyForStudio = julyAndAugustStudioPrice * nights;
                    totalMoneyForApartment = julyAndAugustApartamentPrice * nights;
                    break;
 
            }
            if (nights > 14)
            {
                totalMoneyForApartment -= totalMoneyForApartment * 0.10;
            }
            Console.WriteLine($"Apartment: {totalMoneyForApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
 
 
        }
    }
}