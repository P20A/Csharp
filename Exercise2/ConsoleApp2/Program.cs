using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter a:");
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("enter b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c:");
            c = int.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;
            string strA = $"{a}";
            string strB = $"{b}";
            string strC = $"{c}";
            if (b > 0)
            {
                strB = $"+{b}";
            }

            if (c > 0)
            {
                strC = $"+{c}";
            }
            Console.WriteLine($"{strA}(x^2){strB}x{strC}");
            if (d > 0)
            {
                double x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (d == 0)
            {
                double x = (-b)  / (2 * a);
                Console.WriteLine($"x = {x}");

            }
            else
            {
                Console.WriteLine("the delta is negetive");
            }

        }
    }
}
