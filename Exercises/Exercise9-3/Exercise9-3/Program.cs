using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"tenBase: {i} ==> eightBase: {tenBaseToEightBase(i)}");
            }
        }
        static string tenBaseToEightBase(int number)
        {
            string result = "";
            int bagimande = 0;
            while (number > 0)
            {
                bagimande = number % 8;
                result = bagimande + result;
                number /= 8;
            }

            return result;
        }
    }
}
