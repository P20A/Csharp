using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"enter the #{i+1} number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] copy = new int[n];
            for (int i = 0;i < n; i++)
            {
                copy[i] = array[i];
            }
            foreach (int i in copy)
            {
                Console.WriteLine(i); 
            }
        }
    }
}
