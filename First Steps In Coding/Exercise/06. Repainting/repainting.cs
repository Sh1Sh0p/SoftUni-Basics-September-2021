using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = 1.50 * (nylon + 2);
            double paintPrice = 14.50 * (paint + paint * 0.10);
            double thinnerPrice = 5 * thinner;
            double bags = 0.40;
            double totalSum = nylonPrice + paintPrice + thinnerPrice + bags;
            double work = (totalSum * 0.3) * hours;
            double allSum = totalSum + work;

            Console.WriteLine(allSum);
        }
    }
}