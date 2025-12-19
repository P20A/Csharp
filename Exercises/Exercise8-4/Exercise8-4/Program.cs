using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_4
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
            bool validate = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] != matrix[j,i])
                    {
                        validate = false;
                        break;
                    }
                }
                if (!validate)
                    break;
            }
            if (validate) Console.WriteLine("the matrix is good");
            else Console.WriteLine("the matrix is bad");
        }
    }
}
