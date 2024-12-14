using System;

namespace Second_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("enter the second");
			int Number=Convert.ToInt32(Console.ReadLine());
			int Second=(Number%60);
			int Minute=(Number/60)%60;
			int Hr=(Number/60)/60%60;
			int Days=(Number/60)/60/60%24;
			int Year=(Number/60)/60/60/24;
			Console.WriteLine(Year+"year, "+Days+"days, "+Hr+"hours, "+Minute+"minutes, "+Second+"second.");
			Console.ReadKey();
        }
    }
}
