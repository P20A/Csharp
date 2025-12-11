using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("enter the length: ");
            rectangle.setLength(float.Parse(Console.ReadLine()));
            Console.Write("enter the width: ");
            rectangle.setWidth(float.Parse(Console.ReadLine()));

            Console.WriteLine($"the area is {rectangle.getArea()}");
            Console.WriteLine($"the perimeter is {rectangle.getPerimeter()}");
            Console.WriteLine(rectangle.toString());
        }
    }
}
