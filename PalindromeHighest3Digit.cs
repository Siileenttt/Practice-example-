using System;

namespace LargestPalindrome3Digit
{
    class Program
    {
        static void Main(string[] args)
        {
			int result;
			int check;
			int Number1=0;
			for(int i=999;i>1;i--)
			{
				for(int j=999;j>1;j--)
				{
					result=j*i;
					check=reverse(result);
					if(check==result)//palindrome
					{
					    if(result>Number1)
					        {
					           Number1=result;
				                continue;
					        }
					}
					
				}
				
			}
			Console.WriteLine("largest number Palindrom is "+Number1);
			int reverse(int Number)
			{
				int rev=0;
				while(Number!=0)
				{
					rev=rev*10+Number%10;
					Number=Number/10;
				}
				return rev;
			}
					
		Console.ReadKey();
        }
		
    }
}
