using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChislo = int.Parse(Console.ReadLine());
            int twoChislo = int.Parse(Console.ReadLine());

            if (firstChislo > twoChislo)
            {
                Console.WriteLine(firstChislo);
            }
            else
            {
                Console.WriteLine(twoChislo);
            }
        }
    }
}