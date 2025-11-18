using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first side:");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your secoend side:");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your third side:");
            int side3 = int.Parse(Console.ReadLine());
            
            if (side1 <= side2 + side3 && side2 <= side1 + side3 && side3 <= side2 + side1 )
            {
                Console.WriteLine("it can be traingle.");
            }
            else
            {
                Console.WriteLine("it cant be traingle.");
            }

        }
    }
}
