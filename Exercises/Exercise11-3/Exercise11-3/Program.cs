using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course[] courses = new Course[3];
            courses[0] = new Course("C#", 3, 19, "sotodeh", 8, 0);
            courses[1] = new Course("farsi", 3, 17.5f, "rajabi", 14, 0);
            courses[2] = new Course("riazi", 2, 18, "hossaini", 8, 10);

            Term[] terms = new Term[4];
            terms[0] = new Term(courses, 907);
            terms[1] = new Term(courses, 805);
            terms[2] = new Term(courses, 603);
            terms[3] = new Term(courses, 709);

            Student student = new Student(terms, "parsa", "ataei", 907, "computer engineering");

            Console.WriteLine(student.toString());

        }
    }
}
