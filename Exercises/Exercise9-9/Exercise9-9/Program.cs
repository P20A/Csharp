using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcArea(4));
            Console.WriteLine(CalcArea(5,6));
            Console.WriteLine(CalcArea(8,9,0));
        }
        static int CalcArea(int radius)
        {
            return Convert.ToInt32(Math.PI * Math.Pow(radius,2));
        }
        static int CalcArea(int x,int y)
        {
            return x * y;
        }
        static int CalcArea(int Base, int height,int none)
        {
            return (Base * height) / 2;
        }
    }
}
