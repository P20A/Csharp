using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_4
{
    internal class Student
    {
        private Term[] terms;
        private string firstName;
        private string lastName;
        private int entery;
        private string reshteName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Entery
        {
            get { return entery; }
            set { entery = value; }
        }
        public string ReshteName
        {
            get { return reshteName; }
            set { reshteName = value; }
        }
        public Student(Term[] terms, string firstName, string lastName, int entery, string reshteName)
        {
            this.terms = terms;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Entery = entery;
            this.reshteName = reshteName;
        }

        public string toString()
        {
            return $"first name: {this.FirstName}\nlast name: {this.LastName}\nentery: {this.Entery}\nreshte name: {this.ReshteName}\nfull degree: {fullDegree()}";
        }
        public float fullDegree()
        {
            Term[] terms = this.terms;
            float sum = 0f;
            for (int i = 0; i < terms.Length; i++)
            {
                sum += terms[i].totalDegree();
            }
            return sum / terms.Length;
        }
    }
}
