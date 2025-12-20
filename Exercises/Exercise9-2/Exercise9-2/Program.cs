using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the n: ");
            Console.WriteLine(fibonachi(int.Parse(Console.ReadLine())));
        }
        static int fibonachi(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                return fibonachi(n - 1) + fibonachi(n - 2);
            }
        }
    }
}
