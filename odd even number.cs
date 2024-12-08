using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("enter the number");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0) 
                Console.WriteLine("It is Even Number");
            else
                Console.WriteLine("it is Odd number");
            goto start;
            Console.Read();
        }
    }
}
