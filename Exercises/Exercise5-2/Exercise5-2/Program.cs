using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your 8-bit number:");
            int x = int.Parse(Console.ReadLine());
            int temp = x;
            double result = 0;
            for (int i = 7; i >= 0; i--)
            {
                if (x >= Math.Pow(2, i))
                {
                    x -= (int)Math.Pow(2, i);
                    result += Math.Pow(10,i);
                }
            }
            Console.WriteLine($"{temp} ==> {result}");
        }
    }
}
