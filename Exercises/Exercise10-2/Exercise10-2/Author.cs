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
            set { name = value; }
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
                if (gender == 'm' || gender == 'f')
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
            this.gender = gender;
        }
        public string toString()
        {
            return $"Name: {this.name}\nEmail: {this.email}\nGender: {this.gender}";
        }
    }
}
