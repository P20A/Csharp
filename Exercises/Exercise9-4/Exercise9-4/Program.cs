using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.WriteLine($"a: {a}, b: {b}");
            reverse(ref a,ref b);
            Console.WriteLine("after operation: ");
            Console.WriteLine($"a: {a}, b: {b}");
        }
        static void reverse(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
