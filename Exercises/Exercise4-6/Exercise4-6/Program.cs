using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your binary number:");
            string n = Console.ReadLine();
            string reverse = ""; 
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '1')
                    reverse += '0';
                else
                    reverse += '1';
            }
            Console.WriteLine(reverse);
            
        }
    }
}
