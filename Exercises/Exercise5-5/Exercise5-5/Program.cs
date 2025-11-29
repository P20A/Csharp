using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the limit: ");
            int limit = int.Parse(Console.ReadLine());
            bool valid = false;
            int sum = 0;
            for (int i = 2 ; i < limit; i++)
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
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
