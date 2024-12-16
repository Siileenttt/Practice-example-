using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("enter the Number: ");
			int Number=Convert.ToInt32(Console.ReadLine());
			int Result=Factorial(Number);
			Console.WriteLine(Result);
			
	     int Factorial(int n)
		{
		    if(n==0)
		        return 1;
	        else
		        return n*Factorial(n-1);
		}
		Console.ReadKey();
        }
		
    }
}
