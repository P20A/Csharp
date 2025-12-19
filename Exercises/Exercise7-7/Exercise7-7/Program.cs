using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 0 to exit.");
            while (true)
            {
                Console.Write("enter the number: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                    break;
                int[] firstNumbers = firstnumfinder(num);
                for (int i = 0; i < firstNumbers.Length; i++)
                {
                    for (int j = 0; j < firstNumbers.Length; j++)
                    {
                        if ((firstNumbers[i] + firstNumbers[j]) == num)
                        {
                            Console.WriteLine($"{firstNumbers[i]} + {firstNumbers[j]} == {num}");
                        }
                    }
                }
            }
        }
        static int[] firstnumfinder(int limit)
        {
            int[] result = new int[amountOfFirstNumbers(limit)];
            int indexFinder = 0;
            bool valid = false;
            for (int i = 2; i < limit; i++)
            {
                valid = true;
                for (int j = 2; j < limit; j++)
                {
                    if (i == 2 || i == 3 || i == 5 || i == 7)
                        break;
                    if (i != j && i % j == 0)
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    result[indexFinder] = i;
                    indexFinder++;
                }
            }
            return result;
        }
        static int amountOfFirstNumbers(int limit)
        {
            bool valid = false;
            int counter = 0;
            for (int i = 2; i < limit; i++)
            {
                valid = true;
                for (int j = 2; j < limit; j++)
                {
                    if (i == 2 || i == 3 || i == 5 || i == 7)
                        break;
                    if (i != j && i % j == 0)
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    counter++;
                }
            }
                return counter;
        }

    }
}
