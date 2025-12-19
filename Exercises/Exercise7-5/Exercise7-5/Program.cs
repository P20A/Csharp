using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,100);
            }
            Console.WriteLine("the original array:");
            foreach (var item in array)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.WriteLine("\nthe array after one shift to right:\n");
            int keeper = array[9];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = keeper;
            foreach (var item in array)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.WriteLine("\nthe array after two shift to right:\n");
            keeper = array[9];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = keeper;
            foreach (var item in array)
            {
                Console.WriteLine($"\t{item}");
            }

        }
    }
}
