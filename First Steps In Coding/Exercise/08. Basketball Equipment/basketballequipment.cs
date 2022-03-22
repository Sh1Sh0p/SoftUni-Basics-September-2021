using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            double baskec = year - year * 0.4;

            double basekip = baskec - baskec* 0.2;
            double basball = basekip / 4;
            double basacc = basball / 5;
            Console.WriteLine(baskec + basekip + basball + basacc + year);

        }

    }
}