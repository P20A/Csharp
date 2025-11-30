using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 20);
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine("\nthe uniques are: ");
            bool valid = true;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        valid = false; 
                    }
                }
                if (valid)
                {
                    Console.WriteLine(array[i]);
                }
                valid = true;
            }
        }
    }
}
