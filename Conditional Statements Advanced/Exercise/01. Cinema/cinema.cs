using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFilm = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (typeFilm == "Premiere")
            {
                income = rows * colums * 12.00;
            }
            else if (typeFilm == "Normal")
            {
                income = rows * colums * 7.50;
            }
            else if (typeFilm == "Discount")
            {
                income = rows * colums * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}