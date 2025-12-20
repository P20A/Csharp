using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercise9_6
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
            int small, big;
            finder(array, out small, out big);
            Console.WriteLine($"smallest: {small}, biggest: {big}");

        }
        static void finder(int[] array, out int small, out int big)
        {
            small = 0;
            big = 0;
            int[] arrayS = new int[array.Length];
            int[] arrayB = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayS[i] = array[i];
                arrayB[i] = array[i];
            }
            bool validS = false;
            bool validB = false;
            int validCounterS = 0;
            int validCounterB = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!validS)
                {
                    if (arrayS[i] == int.MaxValue)
                        continue;
                    validCounterS = 0;
                    for (int j = 0; j < arrayS.Length; j++)
                    {
                        if (arrayS[i] <= arrayS[j] && j != i)
                        {
                            validCounterS++;
                        }
                        if (validCounterS == arrayS.Length - 1)
                        {
                            validS = true;
                            small = arrayS[i];
                            arrayS[i] = int.MaxValue;
                            break;
                        }
                    }
                }
                if (!validB)
                {
                    if (arrayB[i] == int.MinValue)
                        continue;
                    validCounterB = 0;
                    for (int j = 0; j < arrayB.Length; j++)
                    {
                        if (arrayB[i] >= arrayB[j] && j != i)
                        {
                            validCounterB++;
                        }
                        if (validCounterB == arrayB.Length - 1)
                        {
                            validB = true;
                            big = arrayB[i];
                            arrayB[i] = int.MinValue;
                            break;
                        }
                    }
                }
                if(validB && validS)
                {
                    break;
                }
                
            }
        }
    }
}
