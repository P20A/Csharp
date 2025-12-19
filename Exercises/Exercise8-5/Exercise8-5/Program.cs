using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the amount of rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("enter the amount of coulmns: ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[row, col];
            Console.WriteLine("enter the matrix1 numbers:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"enter the #{i+1} row and #{j+1} coulmn: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] matrix2 = new int[row, col];
            Console.WriteLine("enter the matrix2 numbers:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"enter the #{i + 1} row and #{j + 1} coulmn: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"\t{matrix1[i,j] + matrix2[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
