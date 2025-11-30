using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_3
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
            }
            int counter = 0;
            for (int i = 0 ;i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        counter++;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine($"\n{counter}");
        }
    }
}
