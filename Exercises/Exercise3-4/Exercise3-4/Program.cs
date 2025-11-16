using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your grade:");
            int grade = int.Parse(Console.ReadLine());
            switch (grade)
            { 
                case 6:
                    Console.WriteLine("your grade is E");
                    break;
                case 7:
                    Console.WriteLine("your grade is D"); 
                    break;
                case 8:
                    Console.WriteLine("your grade is C");
                    break;
                case 9:
                    Console.WriteLine("your grade is B");
                    break;
                case 10:
                    Console.WriteLine("your grade is A");
                    break;
            }       
            
        }
    }
}
