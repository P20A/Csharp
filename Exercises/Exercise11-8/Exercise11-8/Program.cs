using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCircle c1 = new MyCircle(1,1,3);
            Console.WriteLine(c1.toString());
            MyCircle c2 = new MyCircle(4,4,6);
            Console.WriteLine($"distance: {c1.distance(c2)}");
            Console.WriteLine($"area: {c1.getArea()}");
            Console.WriteLine($"circumference: {c1.getCircumference()}");
            
        }
    }
}
