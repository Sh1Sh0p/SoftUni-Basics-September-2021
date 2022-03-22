using System;

namespace PetShop
{
    class Program
    {
        public static void Main(string[] args)
        {
          int dogFood = int.Parse(Console.ReadLine());
		  int catFood = int.Parse(Console.ReadLine());
		  double endPrice = 2.5  dogFood + 4  catFood;
		  Console.WriteLine(${endPrice} lv.);
        }
    }
}