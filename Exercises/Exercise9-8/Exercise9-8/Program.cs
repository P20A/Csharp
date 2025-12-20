using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(avrage(20, 18));
        }
        static int avrage(params int[] numbers)
        {
            int amount = numbers.Length;
            int sum = 0;
            for (int i = 0; i < amount; i++)
            {
                sum += numbers[i];
            }
            return sum/amount;
        }
    }
}
