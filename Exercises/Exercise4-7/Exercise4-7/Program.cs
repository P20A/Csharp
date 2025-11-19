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
            string num = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < num.Length ; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] == num[j]) 
                        counter++;

                }
                Console.WriteLine($"{num[i]} => {counter}");
                counter = 0;

            }
        }
    }
}
