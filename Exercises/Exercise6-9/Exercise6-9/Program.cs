using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the lenth of your array: ");
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"enter the #{i+1} number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("enter the new number:");
            int newNum = int.Parse(Console.ReadLine());
            int[] arranged = new int[array.Length + 1];
            int stamp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(newNum > array[i])
                {
                    arranged[i] = array[i];
                }
                else
                {
                    stamp = i;
                    break;
                }
            }
            arranged[stamp] = newNum;
            for (int i = stamp; i < array.Length; i++)
            {
                arranged[i + 1] = array[i];
            }
            Console.WriteLine("the answer:");
            foreach(int i in arranged)
            {
                Console.WriteLine(i);
            }

        }
    }
}
