using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("enter your y: ");
            int y = int.Parse(Console.ReadLine());

            Mypoint point1 = new Mypoint(x,y);
            Console.WriteLine(point1.toString());
            Console.Write("enter the secoend x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("enter the secoend y: ");
            y = int.Parse(Console.ReadLine());
            Mypoint point2 = new Mypoint(x,y);
            Console.WriteLine($"distance form another point: {point1.distance(point2)}");
            Console.Write("enter the third x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("enter the third y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine($"distance form x,y: {point1.distance(x,y)}");
            Console.WriteLine($"distance form 0,0: {point1.distance()}");

        }
    }
}
