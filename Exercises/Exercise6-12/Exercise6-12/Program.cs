using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_12
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
            // اولین بزرگ ترین پاک می شود:
            biggerFinder(array);
            // دومین بزرگ ترین نمایش داده میشود:
            Console.WriteLine(biggerFinder(array));

        }
        static int biggerFinder(int[] array)
        {
            int result = 0;
            bool valid = false;
            int validCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == int.MinValue)
                    continue;
                validCounter = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j] && j != i)
                    {
                        validCounter++;
                    }
                    if (validCounter == array.Length - 1)
                    {
                        valid = true;
                        result = array[i];
                        array[i] = int.MinValue;
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
