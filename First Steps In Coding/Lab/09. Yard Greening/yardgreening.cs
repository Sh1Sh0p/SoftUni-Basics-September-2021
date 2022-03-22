using System;
 
namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double squareMeters = double.Parse(Console.ReadLine());
 
            double price = squareMeters * 7.61;
            double discount = price * 0.18;
            double totalPrice = price - discount;
 
            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
 
        }
    }
}