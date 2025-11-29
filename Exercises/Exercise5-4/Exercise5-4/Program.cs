using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write('\t');
                        continue;
                    }
                    else if (i == 0)
                    {
                        Console.Write($"{(i + 1) * j}\t");
                    }
                    else if (j == 0)
                    {
                        Console.Write($"{i * (j + 1)}\t");
                    }
                    else
                        Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
