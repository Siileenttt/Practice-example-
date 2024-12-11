using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int rev = 0;
            int Temp = 0;
            Console.WriteLine("enter the Number");
            string Number = (Console.ReadLine());
            int size = Number.Length;
            int Number1 = Convert.ToInt32(Number);
            for (int i = 0; i < size; i++)
            {
                rev = Number1 % 10;
                Number1 = Number1 / 10;
                rev = rev + Temp*10;
                Temp = rev;
            }
            Console.WriteLine("the result is " + rev);
            Console.ReadKey();
        }
    }
}
