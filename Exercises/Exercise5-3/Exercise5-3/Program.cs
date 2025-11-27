using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter #1 number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter #2 number: ");
            int num2 = int.Parse(Console.ReadLine());
            int counter = 2;
            while (true)
            {
                if (counter % num1 == 0 && counter % num2 == 0)
                    break;
                counter++;
            }
            Console.WriteLine(counter);

        }
    }
}
