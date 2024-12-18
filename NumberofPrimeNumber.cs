using System;
class NumberOfPrimeNumber
{
    static void Main()
    {
        int count = 0;
        for (int i = 2; i>1; i++)
        {

            bool Flag = true;
            for (int j = 2; j * j <= i; j++)
            {

                if (i % j == 0)
                {
                    Flag = false;
                    break;
                }


            }
            if (Flag)
            {
                count++;
                if (count==10001)
                    Console.WriteLine(i + "::" + count);
            }
        }
        Console.ReadKey();
    }
}
