using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res1, res2, res3, res4;
            res1 = (-1) + 4 * 6;
            res2 = (35 + 5) % 7;
            res3 = 14 + (-4) * 6 / 11;
            res4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine($"(-1) + 4 * 6 = {res1}");
            Console.WriteLine($"(35 + 5) % 7 = {res2}");
            Console.WriteLine($"14 + (-4) * 6 / 11 = {res3}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {res4}");

        }
    }

}

