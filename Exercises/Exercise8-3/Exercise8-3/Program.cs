using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"enter the #{i + 1} row and #{j + 1} coulmn: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] matrix90 = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == 0)
                    {
                        matrix90[j, 2] = matrix[i, j];
                    }
                    else if(i == 1)
                    {
                        matrix90[j, 1] = matrix[i, j];
                    }
                    else
                    {
                        matrix90[j, 0] = matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < matrix90.GetLength(0); i++)
            {
                for (int j = 0; j < matrix90.GetLength(1); j++)
                {
                    Console.Write($"\t{matrix90[i,j]}");
                }
                Console.WriteLine();
            }

        }
    }
}
