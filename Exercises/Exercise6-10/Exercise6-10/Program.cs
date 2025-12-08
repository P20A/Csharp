using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the length of your array: ");
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"enter the #{i+1} number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\n\nenter the number u want to inject: ");
            int newNum = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length+1];
            for (int i = 0; i < newArray.Length-1; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length-1] = newNum;

            foreach (int i in newArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
