using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if(num%i == 0)
                {
                    sum += i; 
                }   
            }
            if (sum == num)
                Console.WriteLine($"{num} is perfect");
            else
                Console.WriteLine($"{num} is not perfect");
        }
    }
}
