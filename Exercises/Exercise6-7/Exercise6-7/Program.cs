using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the lenth of your array: ");
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"enter the #{i + 1} number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] arranged = new int[array.Length];
            for (int i = 0;i < arranged.Length; i++)
            {
                arranged[i] = smallerFinder(array);
            }
            foreach (int i in arranged)
            {
                Console.WriteLine(i);
            }

        }
        static int smallerFinder(int[] array)
        {
            int result = 0;
            bool valid = false;
            int validCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == int.MaxValue)
                    continue;
                validCounter = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j] && j!=i)
                    {
                        validCounter++;
                    }
                    if (validCounter == array.Length -1 )
                    {
                        valid = true;
                        result = array[i];
                        array[i] = int.MaxValue;
                        break;
                    }
                }
                if (valid)
                    break;
            }
            return result;
        }
    }
}
