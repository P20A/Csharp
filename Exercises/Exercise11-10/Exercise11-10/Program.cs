using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(19, "parsa", 20);
            Console.WriteLine(customer.toString());
        }
    }
}
