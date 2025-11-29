using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the eqoaition is: a*x + b*y = c");
            Console.Write("enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("enter c: ");
            int c = int.Parse(Console.ReadLine());
            int eqo = 0;
            for (int x = 0; x <= c; x++)
            {
                for (int y = 0; y <= c; y++)
                {
                    eqo = a * x + b * y;
                    if (eqo == c)
                    {
                        Console.WriteLine($"{a}*{x} + {b}*{y} = {c}");
                    }
                }
            }

        }
    }
}
