using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_6
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
            int middle = array.Length / 2;
            int absTracker = 0;
            int forward = 0;
            int backward = 0;
            int divider = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[middle] == 0)
                {
                    if (absTracker % 2 == 0)
                    {
                        if (array[middle + forward] == 0)
                        {
                            forward++;
                            absTracker++;
                            continue;
                        }
                        else
                        {
                            divider = array[middle + forward];
                            break;
                        }
                    }
                    else
                    {
                        if (array[middle - backward] == 0)
                        {
                            backward++;
                            absTracker++;
                            continue;
                        }
                        else
                        {
                            divider = array[middle - backward];
                            break;
                        }   
                    }
                }
                else
                {
                    divider = array[middle];
                    break;
                }  
            }
            if (divider == 0)
            {
                Console.WriteLine("every parameter was 0");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] / divider;
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
