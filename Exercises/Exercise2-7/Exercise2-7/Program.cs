using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int num = int.Parse(Console.ReadLine());
            int result = (num * (num + 1)) / 2;
            Console.WriteLine($"the result is: {result}");
        }
    }
}
    