using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            int checker = num;

            for (int i = 0; i < 10; i++)
            {
                while (checker != 0) 
                {
                    if (checker%10 == i)
                        counter++;
                    checker /= 10;
                }
                if(counter >0)
                    Console.WriteLine($"{i} ==> {counter}");
                counter = 0;
                checker = num;
            }
            
        }
    }
}
