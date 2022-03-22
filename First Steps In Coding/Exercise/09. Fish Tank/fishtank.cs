using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            int volume = lenghtCm * widthCm * heightCm;
            double volumeLit = volume * 0.001;
            double busyPlace = procent * 0.01;
            double procentTwo = 1 - busyPlace;
            double reqLit = volumeLit * procentTwo;

            Console.WriteLine(reqLit);
        }
    }
}