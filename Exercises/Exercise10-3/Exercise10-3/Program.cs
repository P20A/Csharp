using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author[] authors = new Author[2];
            for (int i = 0; i < authors.Length; i++)
            {
                Console.Write($"enter the #{i + 1} author's name: ");
                string authorName = Console.ReadLine();
                Console.Write($"enter the #{i + 1} author's email: ");
                string authorEmail = Console.ReadLine();
                Console.Write($"enter the #{i + 1} author's gender: ");
                char authorGender = char.Parse(Console.ReadLine());
                authors[i] = new Author( authorName, authorEmail, authorGender );
            }


            Console.WriteLine("enter the book infos:");
            Console.Write("enter the name: ");
            string name = Console.ReadLine();
            Console.Write("enter the price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("enter the qty: ");
            int qty = int.Parse(Console.ReadLine());
            Book book = new Book(name, authors, price, qty);

            Console.WriteLine(book.toString());


        }
    }
}
