using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_2
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
                    Console.Write($"enter the #{i+1} row and #{j+1} coulmn: ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            Console.WriteLine("the sum of the every parameter in the rows: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.WriteLine("the sum of the every parameter in the coulmns: ");

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
                
            }
        }
    }
}
