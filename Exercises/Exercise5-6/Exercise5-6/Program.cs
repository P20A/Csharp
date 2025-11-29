using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the n: ");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    counter++;
                }
                else
                {
                    n = (n * 3) + 1;
                    counter++;
                }   
            }
            Console.WriteLine(counter);
        }
    }
}
