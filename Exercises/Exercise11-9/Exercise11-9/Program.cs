using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPoint v1 = new MyPoint(0, 0);
            MyPoint v2 = new MyPoint(0, 1);
            MyPoint v3 = new MyPoint(1, 0);
            
            MyTriangle triangle = new MyTriangle(v1, v2, v3);
            Console.WriteLine(triangle.toString());
            Console.WriteLine(triangle.getType());
            Console.WriteLine(triangle.getPerimeter());

        }
    }
}
