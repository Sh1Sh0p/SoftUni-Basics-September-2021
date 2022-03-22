using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = Console.ReadLine();

            string passwordRepeat = Console.ReadLine();

            while (password != passwordRepeat)
            {
                passwordRepeat = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}