using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2
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

            if (a == b && a == c & b == c)
            {
                Console.WriteLine("motasavi alazla");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("motasavi alsaghein");
            }
            else if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)) || Math.Pow(b, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2)) || Math.Pow(c, 2) == (Math.Pow(b, 2) + Math.Pow(a, 2)))
            {
                Console.WriteLine("qaem olzavie");
            }
            else
            {
                Console.WriteLine("mamoli");
            }

        }
    }
}
