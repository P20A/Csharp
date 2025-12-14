using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the amount of students: ");
            int[,] students = new int[int.Parse(Console.ReadLine()), 2];
            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.Write($"enter the #{i + 1} student's id: ");
                students[i, 0] = int.Parse(Console.ReadLine());
                Console.Write($"enter the #{i + 1} student's study code: ");
                students[i, 1] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            for (int i = 0; i < students.GetLength(0); i++)
            {
                counter = 1;
                if (students[i, 1] == int.MaxValue) { continue; }
                Console.WriteLine($"--------------{students[i, 1]}--------------");
                for (int j = i + 1; j < students.GetLength(0); j++)
                {
                    if (students[i, 1] == students[j, 1])
                    {
                        students[j, 1] = int.MaxValue;
                        counter++;
                    }
                }
                Console.WriteLine(counter);

            }
        }
    }
}
