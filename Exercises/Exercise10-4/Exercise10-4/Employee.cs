using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_4
{
    internal class Employee
    {
        private int id;
        private int Id
        {
            get { return id; }
        }
        private string firstName;
        private string FirstName
        {
            get { return firstName; }
        }
        private string lastName;
        private string LastName
        {
            get { return lastName; }
        }
        private int salary;
        private int Salary
        {
            get { return salary; }
            set 
            {
                if(value > 0) 
                    salary = value; 
                else
                    salary = 0;
            }
        }
        public Employee(int id, string firstName, string lastName, int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        public string getName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
        public int getAnnualSalary()
        {
            return Salary * 12;
        }
        public int raiseSalary(int percent)
        {
            Salary += Salary * percent/100;
            return Salary;
        }
        public string toString()
        {
            return $"id: {this.Id}\nname: {getName()}\nsalary: {Salary}";
        }
    }
}
