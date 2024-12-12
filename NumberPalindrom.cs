using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPalindrom
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
            int Compare=Number1;
            for (int i = 0; i < size; i++)
            {
                if (Number1<10)
                    rev=Number1;
                else    
                    rev = Number1 % 10;
                    
                Number1 = Number1 / 10;
                rev = rev + Temp*10;
                Temp = rev;
            }
			if (rev==Compare)
				Console.WriteLine("the Number"+Compare+ "is palindrom");
			else
				Console.WriteLine("it is not Palindrom");
            Console.ReadKey();
        }
    }
}
