using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the matrix1 amount of rows: ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("enter the matrix1 amount of coulmns: ");
            int col1 = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[row1, col1];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write($"enter the #{i + 1} row and #{j + 1} coulmn: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("enter the matrix2 amount of rows: ");
            int row2 = int.Parse(Console.ReadLine());
            Console.Write("enter the matrix2 amount of coulmns: ");
            int col2 = int.Parse(Console.ReadLine());
            int[,] matrix2 = new int[row2, col2];
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write($"enter the #{i + 1} row and #{j + 1} coulmn: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] afterOperation = new int[row1, col2];
            if (col1 != row2)
                Console.WriteLine("the operation can not be done(col1 != row2");
            else
            {
                int sum = 0;
                int AOCol = 0;
                int AORow = 0;                
                for (int i = 0; i < row1; i++)
                {
                    for (int k = 0; k < col2; k++)
                    {
                        for (int j = 0; j < col1; j++)
                        {
                            sum += matrix1[i, j] * matrix2[j, k];
                        }
                        afterOperation[AORow, AOCol] = sum;
                        AOCol++;
                        sum = 0;
                    }
                    AORow++;
                    AOCol = 0;
                }
                for (int i = 0; i < afterOperation.GetLength(0); i++)
                {
                    for(int j = 0;j < afterOperation.GetLength(1); j++)
                    {
                        Console.Write($"\t{afterOperation[i, j]}");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
