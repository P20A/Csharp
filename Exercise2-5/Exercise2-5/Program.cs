using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 43;
            int y = 554;
            int z = 34;
            Console.WriteLine($"(x+y)*z = {(x + y) * z}");
            Console.WriteLine($"x*y+y*z = {x * y + y * z}");
        }
    }
}