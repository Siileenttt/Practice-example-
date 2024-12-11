using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitRecursion
{
    class Program
    {
        static int b = 0,a=0;
        static int Number;

        private static int Add(int Number)
        {
            int Number1 = Number;
            a =Number1%10 ;
            Number1 = Number1 / 10;
            a = a + b;
            b = a;
            if (Number1== 0)
            {
                return a;
            }
            else
                return Add(Number1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            Number = Convert.ToInt32(Console.ReadLine());
            int result = Add(Number);
            Console.WriteLine("the sum of Number\n" + result);
            Console.ReadKey();
        }
    }
}
