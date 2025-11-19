using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter x:");
            int x = int.Parse(Console.ReadLine());
            int pow = 1;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i%2 == 0)
                    sum += Math.Pow(x, pow);
                else 
                    sum += -(Math.Pow(x, pow));
                pow += 2;
            }
            Console.WriteLine(sum);
        }
    }
}
