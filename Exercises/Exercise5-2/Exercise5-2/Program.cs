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
            string result = "";
            for (int i = 7; i >= 0; i--)
            {
                if (x >= Math.Pow(2, i))
                {
                    x -= (int)Math.Pow(2, i);
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }
            Console.WriteLine($"{temp} ==> {result}");
        }
    }
}
