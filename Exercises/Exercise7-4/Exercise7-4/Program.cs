using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 5);
            }
            int[] array2 = new int[10];
            int counter = 0;
            for (int k = 0; k < array.Length; k++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j] && i != j)
                        {
                            counter++;
                        }
                    }
                    array2[i] = counter;
                    counter = 0;
                }
            }

            int result = 0;
            bool valid = false;
            int validCounter = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] == int.MinValue)
                    continue;
                validCounter = 0;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[i] >= array2[j] && j != i)
                    {
                        validCounter++;
                    }
                    if (validCounter == array2.Length - 1)
                    {
                        valid = true;
                        result = array2[i];
                        array2[i] = int.MinValue;
                        break;
                    }
                }
                if (valid)
                {
                    Console.WriteLine($"{array[i]} ==> {result}");
                    break;
                }
                    
            }
        }

    }
}
