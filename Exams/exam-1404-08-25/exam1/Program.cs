using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int num = 0;    
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        num = i * 1000 + j * 100 + j * 10 + k;
                        Console.WriteLine($"generated number: {num}");
                        result = ((int)Math.Pow(i,2)) + j*2 + fact(j) + k ;
                        Console.WriteLine($"the sum is: {result}");
                        if ( result == 100)
                        {
                            Console.WriteLine("the number is good");
                        }
                    }
                }
            }
        }
        static int fact(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
            
        }
        
    }
}
