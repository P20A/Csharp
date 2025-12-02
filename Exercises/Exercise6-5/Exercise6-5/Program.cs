using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the first array: ");
            int[] array1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"enter the #{i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the secoend array: ");
            int[] array2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"enter the #{i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            
            int[] array3 = new int[10];
            while (counter3 != 10 ) 
            {
                if (counter1 == 5)
                {
                    array3[counter3] = array2[counter2];
                    counter2++;
                    break;
                }
                else if (counter2 == 5)
                {
                    array3[counter3] = array1[counter1];
                    counter1++;
                    break;
                }
                else if (array1[counter1] > array2[counter2])
                {
                    array3[counter3] = array2[counter2];
                    counter2++;
                }
                else if (array2[counter2] > array1[counter1])
                {
                    array3[counter3] = array1[counter1];
                    counter1++;
                }
                else
                {
                    array3[counter3] = array1[counter1];
                    counter1++;

                    counter3++;

                    array3[counter3] = array2[counter2];
                    counter2++;
                }
                counter3++;
            }
            foreach (int i in array3)
            {
                Console.WriteLine(i);
            }
        }
    }
}