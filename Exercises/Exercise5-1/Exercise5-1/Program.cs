using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter your 2 based number:");
                int x = int.Parse(Console.ReadLine());
                int temp = x;
                double result = 0;
                int counter = 0;
                while (x != 0)
                {
                    if (x % 2 == 1)
                    {
                        result += Math.Pow(2, counter);
                    }
                    x /= 10;
                    counter++;
                }
                Console.WriteLine($"{temp} ==> {result}");
            }
            
        }
    }
}
