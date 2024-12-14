using System;

namespace Even_Fibonacci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = 1;  
            long secondNumber = 2; 
            long evenSum = 0;

            
            while (firstNumber <= 40000)
            {
                if (firstNumber % 2 == 0)
                {
                    evenSum =evenSum + firstNumber;
                }

                
                long nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }

            Console.WriteLine("The sum of even Fibonacci numbers less than 4000 is: " + evenSum);
            Console.ReadKey();
        }
    }
}
