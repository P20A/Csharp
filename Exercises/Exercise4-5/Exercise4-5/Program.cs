using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how meny times?");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                num *= 10;
                num += 1;
                sum += num;
            }
            Console.WriteLine(sum);

        }
    }
}
