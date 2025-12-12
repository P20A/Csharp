using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_7
{
    internal class InvoiceItem
    {
        private string id;
        private string desc;
        private int qty;
        private double unitPrice;
        private string Id
        {
            get {  return id; }
        }
        private string Desc
        {
            get { return desc;}
        }
        private int Qty
        {
            get { return qty; }
            set
            {
                if (value < 1)
                    qty = 0;
                else
                    qty = value;
            }
        }
        private double UnitPrice 
        {
            get { return unitPrice; }
            set
            {
                if (value < 1)
                    unitPrice = 0;
                else
                    unitPrice = value;
            }
        }
        public InvoiceItem(string id, string desc, int qty, double unitPrice)
        {
            this.id = id;
            this.desc = desc;
            this.Qty = qty;
            this.UnitPrice = unitPrice;
        }
        public double getTotal()
        {
            return UnitPrice * Qty;
        }
        public string toString()
        {
            return $"id: {this.Id}\ndesc: {this.Desc}\nqty: {this.Qty}\nunit price: {this.UnitPrice}";
        }
    }
}
