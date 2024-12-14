using System;

namespace Hight_Category
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("enter the height in inches");
			int Number=Convert.ToInt32(Console.ReadLine());
			float Height=Number*2.54f;
			string Status;
			if(Height<150)
				Status="Dwarf";
			else if(Height>=150&&Height<165)
				Status="Average Height";
			else if(Height>=165&&Height<195)
				Status="Tall";
			else
				Status="Abnormal height";
			Console.WriteLine(Status);
			Console.ReadKey();
        }
    }
}
