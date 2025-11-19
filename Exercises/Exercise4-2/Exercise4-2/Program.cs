using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter row count:");
            int row = int.Parse(Console.ReadLine());
            string printer = "";
            for (int i = 1; i <= row; i++)
            {
                if (i % 2 == 0)
                    printer = "0" + printer;
                else printer = "1" + printer;
                Console.WriteLine(printer);
            }
        }
    }
}
