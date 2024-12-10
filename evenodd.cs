using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("it is even number");
            }
            else
                Console.WriteLine("it is odd");
            Console.ReadKey();

        }
    }
}
