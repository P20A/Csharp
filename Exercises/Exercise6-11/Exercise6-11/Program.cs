using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the length of your array: ");
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"enter the #{i + 1} number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\n\nenter the number u want to remove: ");
            int numToRemove = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length - 1];
            int placeholder = 0;
            bool error = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numToRemove)
                {
                    placeholder = i;
                    break;
                }
                else if (newArray.Length != i)
                    newArray[i] = array[i];
                else
                {
                    Console.WriteLine("the number u wanted to remove doenst exist in the array.");
                    error = true;
                    break;
                }
            }
            for (int i = placeholder; i < newArray.Length && !error; i++)
                newArray[i] = array[i + 1];
            if (!error)
                foreach (int i in newArray)
                    Console.WriteLine(i);
        }
    }
}
