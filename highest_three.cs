using System;

namespace Highest_Three
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("enter the Number");
			int num1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter the Number");
			int num2=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter the Number");
			int num3=Convert.ToInt32(Console.ReadLine());
			int Highest;
			if(num1>num2)
				if(num1>num3)
					Highest=num1;
				else
					Highest=num3;
			else
				if(num2>num3)
					Highest=num2;
				else
					Highest=num3;
			Console.WriteLine(Highest);
			Console.ReadKey();
        }
    }
}
