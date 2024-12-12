using System;
namespace SimpleCalculator
{
	class Calculator
	{
		static void Main(string[] arg)
		{
			Console.WriteLine("enter the number 1");
			int number1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter the number 2");
			int number2=Convert.ToInt32(Console.ReadLine());
			int sum=number1+number2;
			int subtract=number1-number2;
			float divide=number1/number2;
			int multiply=number1*number2;
			Console.WriteLine($"sum is{sum}");
			Console.WriteLine($"subtraction is {subtract}");
			Console.WriteLine($"divide is {divide}");
			Console.WriteLine($"multiply is {multiply}");
		}
	}
}