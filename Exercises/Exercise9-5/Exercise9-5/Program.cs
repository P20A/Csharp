using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter b: ");
            int b = int.Parse(Console.ReadLine());
            int plus, minus, times, divid;
            calc(a, b, out plus, out minus, out times, out divid);
            Console.WriteLine($"\n\nplus: {plus}\nminus: {minus}\ntimes: {times}\ndivid: {divid}");
        }
        static void calc(int a, int b,out int plus,out int minus,out int times,out int divid)
        {
            times = a * b;
            divid = a / b;
            plus = a + b;
            minus = a - b;
        }
    }
}
