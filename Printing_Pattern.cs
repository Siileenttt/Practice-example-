using System;

namespace Printing_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
			for(int i=1;i<=5;i++)
			{
			    for(int j=4;j>=i;j--)
				    Console.Write(" ");
			    for(int k=1;k<=i;k++)
			    {
			        if(k>=2)
			            Console.Write(" ");
		            Console.Write("*");
			    }
			    Console.WriteLine();
			}
			Console.ReadKey();
        }
    }
}
