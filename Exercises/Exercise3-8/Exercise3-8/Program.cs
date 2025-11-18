using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your oprator:");
            int opt = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter your secoend number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (opt)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            Console.WriteLine($"the result is: {result}");
        }
    }
}
