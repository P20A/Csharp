using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "parsa" ,50);

            Invoice invoice = new Invoice(0, customer, 400);

            Console.WriteLine(invoice.getCustomerName());
            Console.WriteLine(invoice.getAmountAfterDiscount());
        }
    }
}
