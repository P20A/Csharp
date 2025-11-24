using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool v = false;
            for (int i = 1; i <=6; i++)
            {
                v = false;
                for (int j = 1; j <= 6; j++)
                {
                    
                    if (i == j )
                    {
                        Console.Write(0);
                        v = true;
                    }
                    else
                    {
                        if (v)
                            Console.Write(j - 1);
                        else
                            Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
