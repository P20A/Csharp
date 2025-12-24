using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_6
{
    internal class Author
    {
        private string name;

        private string email;

        private char gender;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }
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
            return $"Name: {name}\nEmail: {email}\nGender: {gender}";
        }
    }
}
