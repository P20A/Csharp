using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 45;
            int holder = 0;
            holder = num1;
            num1 = num2;
            num2 = holder;
            Console.WriteLine($"num1:{num1} , num2:{num2}");

            Console.ReadKey();
        }
    }
}
