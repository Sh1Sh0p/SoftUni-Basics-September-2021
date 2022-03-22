using System;

namespace VacationBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysReadBook = int.Parse(Console.ReadLine());
            int allTimeForReading = bookPages / pagesPerHour;
            int timeForReadingDay = allTimeForReading / daysReadBook;

            Console.WriteLine(timeForReadingDay);
        }
    }
}