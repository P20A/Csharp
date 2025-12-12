using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Exercise10_3
{
    internal class Book
    {
        private string name;
        private Author[] authors;
        private double price;
        private int qty = 0;
        private string Name
        {
            get { return name; }
        }
        private double Price
        {
            get { return price; }
            set 
            {
                if(price >= 0)
                    price = value;
                else
                    Console.WriteLine("price should be a postive number");
            }
        }
        private int Qty
        {
            get { return qty;}
            set { qty = value; }
        }
        public Author[] Authors
        {
            get { return authors;}
            set { authors = value;}
        }
        public Book(string name, Author[] authors, double price,int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }
        public Book(string name, Author[] authors, double price)
            :this(name, authors, price, 0) { }
        public string getAuthorsNames()
        {
            string allNames = "";
            foreach(var author in authors)
            {
                allNames += "\n*********\n" + author.toString() + "\n*********";
            }
            return allNames;
        }
        public string toString()
        {
            return $"name: {this.name}\nprice: {this.Price}\nauthor: {getAuthorsNames()}\nqty: {this.qty}";
        }
    }
}
