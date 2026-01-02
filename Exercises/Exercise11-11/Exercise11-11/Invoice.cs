using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_11
{
    internal class Invoice
    {
        private int id;
        private Customer customer;
        private double amount;

        public int Id
        {
            get { return id; }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Invoice(int id, Customer customer, double amount)
        {
            this.id = id;
            this.Customer = customer;
            this.Amount = amount;
        }
        public string getCustomerName()
        {
            return this.customer.Name;
        }
        public double getAmountAfterDiscount()
        {
            double result = amount - (amount * (customer.Discount / 100d));
            return result;
        }
    }
}
