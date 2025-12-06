using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how long is your array? ");
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"enter the #{i+1} number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                counter = 1;
                if (array[i] == int.MaxValue)
                    continue;
                for (int j = i+1; j < array.Length && j > i; j++)
                {
                    if( array[i] == array[j])
                    {
                        counter++;
                        array[j] = int.MaxValue;
                    }
                }
                Console.WriteLine($"{array[i]} ==> {counter}");
            }

            
        }
    }
}
