using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character:");
            char sounded = Convert.ToChar(Console.ReadLine());

            switch (sounded)
            {
                case 'a': Console.WriteLine("a is sounded"); break;
                case 'o': Console.WriteLine("o is sounded"); break;
                case 'i': Console.WriteLine("i is sounded"); break;
                case 'y': Console.WriteLine("y is sounded"); break;
                case 'u': Console.WriteLine("u is sounded"); break;
                case 'e': Console.WriteLine("e is sounded"); break;
                default: Console.WriteLine($"{sounded} is not sounded"); break;
            }
        }
    }
}
