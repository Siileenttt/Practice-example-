using System;
class Smallest_Multiple
{
    static void Main()
    {
        double Result = 0;
        bool flag = false;
        
        for (int i = 21; i > 1; i++)
        {
            int k = 1;
            for (int j = 2; j <= 20; j++)
            {
                Result = i % j;
                if (Result != 0)
                    break;
                else
                    k++;
                if (k == 19)
                {
                    flag = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (flag == true)
            break;
        }
        Console.ReadKey();
    }
}
