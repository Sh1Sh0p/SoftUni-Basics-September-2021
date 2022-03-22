using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int numPens = int.Parse(Console.ReadLine());
            int numMarkers = int.Parse(Console.ReadLine());
            double litPrep = double.Parse(Console.ReadLine());
            double offPrecent = double.Parse(Console.ReadLine());

            double pricePens = numPens * 5.8;
            double priceMarkers = numMarkers * 7.2;
            double pricePrep = litPrep * 1.2;
            double offPrecentForConsole = offPrecent / 100;

            double price = pricePens + priceMarkers + pricePrep;
            double offPrice = price - offPrecentForConsole * price;
            Console.WriteLine(offPrice);

        }
    }
}