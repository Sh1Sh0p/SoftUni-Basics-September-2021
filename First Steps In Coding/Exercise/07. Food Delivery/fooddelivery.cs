using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пилешко меню – 10.35 лв.
            // Меню с риба – 12.40 лв.
            // Вегетарианско меню – 8.15 лв.
            // Десерт - 0.20 * (общата сметка, БЕЗ ДОСТАВКАТА) 
            // Доставка - 2.50 лв. (добавя се най-накрая)

            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veganMenus = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenus * 10.35;
            double fishPrice = fishMenus * 12.40;
            double veganPrice = veganMenus * 8.15;
            double threePrice = chickenPrice + fishPrice + veganPrice; // не се добавя
            double dessert = 0.20 * threePrice;
            const double delivery = 2.50;

            double endPrice = chickenPrice + fishPrice + veganPrice + dessert + delivery;
            Console.WriteLine(endPrice);
        }
    }
}