using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checker(2, 5, 5, 76, 74);
        }
        static void checker(params int[] numbers)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    a = numbers[i];
                    b = numbers[j];

                    if (a != 0 && b != 0)
                    {
                        if (a % b == 0 || b % a == 0)
                        {
                            Console.WriteLine($"{a} , {b}");
                        }
                    }
                }
            }
        }
    }
}
