using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("acording to my calculation the answer is 17");
            int A = 10;
            int B = 15;
            int C = A++ - -B++ -A +3;
            Console.WriteLine($"and the real answer is {C}");
        }
    }
}
