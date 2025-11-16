using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("d:");
            int d = int.Parse(Console.ReadLine());

            if(a >= b && a >= c && a >= d)
            {
                Console.WriteLine($"{a} is the bigest number");
            }
            else if (b >= a && b >= c && b >= d)
            {
                Console.WriteLine($"{b} is the bigest number");
            }
            else if(c >= a && c >= b && c >= d)
            {
                Console.WriteLine($"{c} is the bigest number");
            }
            else if(d >= a && d >= b && d >= c)
            {
                Console.WriteLine($"{d} is the bigest number");
            }

        }
    }
}
