using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursion = double.Parse(Console.ReadLine());
            int brp = int.Parse(Console.ReadLine());
            int brk = int.Parse(Console.ReadLine());
            int brm = int.Parse(Console.ReadLine());
            int brmn = int.Parse(Console.ReadLine());
            int brkm = int.Parse(Console.ReadLine());
            const double puzzle = 2.60;
            const double doll = 3;
            const double teddybear = 4.10;
            const double minion = 8.20;
            const double truckToy = 2;
            double sum = brp * puzzle + brk * doll + brm * teddybear + brmn * minion + brkm * truckToy;
            int broi = brp + brk + brm + brmn + brkm;
            if (broi >= 50 )
            {
                sum *= 0.75;
            }
            double rent = sum * 0.10;
            double rent = Math.Abs(rent + excursion - sum);
            if ( sum >= rent + excursion)
            {
                Console.WriteLine($"Yes! {rent:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {rent:f2} lv needed.");
            }
        }
    }
}