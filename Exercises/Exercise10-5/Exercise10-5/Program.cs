using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(0, 0, 0);
            Console.WriteLine(time.toString());
            time.previousSecond();
            Console.WriteLine(time.toString());
            time.nextSecond();
            Console.WriteLine(time.toString());
        }
    }
}
