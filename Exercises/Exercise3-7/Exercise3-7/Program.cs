using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your sallery:");
            int sallery = int.Parse(Console.ReadLine());
            int tax = 0;
            int afterTax = 0;
            if (sallery <= 500000 )
            {
                afterTax = sallery;
            }
            else if (sallery <= 1000000)
            {
                tax = 10;
                afterTax = sallery - (sallery / tax);
            }
            else
            {
                tax = 15;
                afterTax = sallery - (sallery / tax);
            }
            Console.WriteLine($"your sallery is: {afterTax} after {tax}% tax");

        }

        
    }
}
