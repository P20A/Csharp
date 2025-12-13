using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Exercise7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the length of the first array: ");
            int[] array1 = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"enter the #{i + 1} number: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("enter the length of the first array: ");
            int[] array2 = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"enter the #{i + 1} number: ");
                array2[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        counter++;
                    }
                }
            }
            int[] array3 = new int[counter];
            counter = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        array3[counter] = array1[i];
                        counter++;
                    }
                }
            }
            foreach (var item in array3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
