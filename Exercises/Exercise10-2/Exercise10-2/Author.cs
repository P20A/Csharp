using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_2
{
    internal class Author
    {
        private string name;
        private string Name
        {
            get { return name; }
        }
        private string email;
        private string Email
        {
            get {  return email; }
            set { email = value; }
        }
        private char gender;
        private char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'm' || value == 'f')
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("the selected gender is not valid.");
                }
            }
        }
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.Gender = gender;
        }
        public string toString()
        {
            return $"Name: {this.Name}\nEmail: {this.Email}\nGender: {this.Gender}";
        }
    }
}
