using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your grade");
            int grade = int.Parse(Console.ReadLine());
            if(grade <= 20)
            {
                Console.WriteLine("your grade is E");
            }
            else if(grade <= 40)
            {
                Console.WriteLine("your grade is D");
            }
            else if (grade <= 60)
            {
                Console.WriteLine("your grade is C");
            }
            else if (grade <= 80)
            {
                Console.WriteLine("your grade is B");
            }
            else if (grade <= 100)
            {
                Console.WriteLine("your grade is A");
            }
        }
    }
}
