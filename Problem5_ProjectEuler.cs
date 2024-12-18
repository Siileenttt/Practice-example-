using System;
class Smallest_Multiple
{
    static void Main()
    {
        long Sum=0, Square_Sum=0;
        long Difference;
        for(int i =1;i<=100;i++)
        {
            Sum = Sum + i;
            Square_Sum = Square_Sum + i * i;
        }
        Difference = Sum * Sum - Square_Sum;
        Console.WriteLine(Difference);
        Console.ReadKey();
    }
}
