using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();
            if (figures == "square")
            {
                double lenghtSide = double.Parse(Console.ReadLine());
                double squareArea = lenghtSide * lenghtSide;
                Console.WriteLine($"{squareArea:f3}");
            }
            else if (figures == "rectangle")
            {
                double oneSide = double.Parse(Console.ReadLine());
                double twoSide = double.Parse(Console.ReadLine());
                double rectangleArea = oneSide * twoSide;
                Console.WriteLine($"{rectangleArea:f3}");
            }
            else if (figures == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine($"{circleArea:f3}");
            }
            else if (figures == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double heightSide = double.Parse(Console.ReadLine());
                double triangleArea = side * heightSide / 2;
                Console.WriteLine($"{triangleArea:f3}");
            }
        }
    }
}