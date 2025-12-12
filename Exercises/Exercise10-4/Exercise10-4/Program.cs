using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("enter salary: ");
            int salary = int.Parse(Console.ReadLine());

            Employee employee = new Employee(id,firstName,lastName,salary);

            Console.WriteLine($"the annual salary is {employee.getAnnualSalary()}");
            Console.WriteLine(employee.toString());
            Console.Write("how much do u want to raise the salary(percentage): ");
            int percent = int.Parse(Console.ReadLine());
            employee.raiseSalary(percent);
            Console.WriteLine(employee.toString());

        }
    }
}
