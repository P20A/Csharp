using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"enter #{i + 1} number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int j = array.Length-1;
            int[] reverse = new int[10];
            for (int i = 0;i < array.Length; i++)
            {
                reverse[i] = array[j];
                j--;
            }
            foreach (int i in reverse)
            {
                Console.WriteLine(i);
            }
        }
    }
}   
