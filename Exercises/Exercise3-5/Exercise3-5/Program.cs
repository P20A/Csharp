using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number:");
            double x = Convert.ToDouble(Console.ReadLine());
            double result;
            if (x < 0)
            {
                result = x + 1;
            }
            else if (x >= 0 && x < 1)
            {
                result = -(Math.Pow(x, 2));
            }
            else 
            {
                result = 1d / x;
            }
            Console.WriteLine(result);
        }
    }
}
