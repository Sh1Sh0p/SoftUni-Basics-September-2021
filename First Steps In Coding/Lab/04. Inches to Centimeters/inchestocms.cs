using System;

namespace InchesToCms
{
    class Program
    {
        static void Main(string[] args)
        {
            	double inch = double.Parse(Console.ReadLine());
		double centimetre = inch * 2.54;
		Console.WriteLine(centimetre);
        }
    }
}