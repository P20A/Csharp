using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the id: ");
            string id = Console.ReadLine();
            Console.Write("enter the desc: ");
            string desc = Console.ReadLine();
            Console.Write("enter the qty: ");
            int qty = int.Parse(Console.ReadLine());
            Console.Write("enter the unit price: ");
            double unitPrice = double.Parse(Console.ReadLine());

            InvoiceItem invoiceItem = new InvoiceItem(id, desc, qty, unitPrice);
            Console.WriteLine($"the total price is: {invoiceItem.getTotal()}");
            Console.WriteLine(invoiceItem.toString());
        }
    }
}
