using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_11
{
    internal class Customer
    {
        private int id;
        private string name;
        private int discount;
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Discount
        {
            get { return discount; }
            set
            {
                if (value >= 0 && value <= 100)
                    discount = value;
                else if (value < 0)
                    discount = 0;
                else
                    discount = 100;
            }
        }
        public Customer(int id, string name, int discount)
        {
            this.id = id;
            this.name = name;
            this.Discount = discount;
        }
        public string toString()
        {
            return $"{this.Name}({this.Id})";
        }
    }
}
