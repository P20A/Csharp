using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the name: ");
            string name = Console.ReadLine();
            Console.Write("enter the email: ");
            string email = Console.ReadLine();
            Console.Write("enter the gender: ");
            char gender = Convert.ToChar(Console.ReadLine());
            Author author = new Author(name, email, gender);

            Console.WriteLine(author.toString());
        }
    }
}
