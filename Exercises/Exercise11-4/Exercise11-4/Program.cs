using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course[] courses = new Course[3];
            Term[] terms = new Term[2];
            Student[] students = new Student[3];

            courses[0] = new Course("C#", 3, 13, "sotodeh", 8, 0);
            courses[1] = new Course("farsi", 3, 12.5f, "rajabi", 14, 0);
            courses[2] = new Course("riazi", 2, 10, "hossaini", 8, 10);
            terms[0] = new Term(courses, 907);

            courses[0] = new Course("standard", 2, 15, "khaleghi", 12, 0);
            courses[1] = new Course("kar rah", 2, 14.25f, "ashrafi", 10, 0);
            courses[2] = new Course("tarbiat badani", 1, 15, "momen", 12, 30);
            terms[1] = new Term(courses, 805);

            students[0] = new Student(terms, "parsa", "ataei", 907, "computer engineering");
            Console.WriteLine($"student 1: {students[0].fullDegree()}");

            courses[0] = new Course("C#", 3, 20, "sotodeh", 8, 0);
            courses[1] = new Course("farsi", 3, 19.5f, "rajabi", 14, 0);
            courses[2] = new Course("riazi", 2, 17, "hossaini", 8, 10);
            terms[0] = new Term(courses, 907);

            courses[0] = new Course("standard sazi", 2, 20, "khaleghi", 12, 0);
            courses[1] = new Course("kar rah", 2, 20, "ashrafi", 10, 0);
            courses[2] = new Course("tarbiat badani", 1, 20, "momen", 12, 30);
            terms[1] = new Term(courses, 805);

            students[1] = new Student(terms, "parsa 2", "ataei 2", 465, "computer engineering");
            Console.WriteLine($"student 2: {students[1].fullDegree()}");


            courses[0] = new Course("C#", 3, 15.75f, "sotodeh", 8, 0);
            courses[1] = new Course("farsi", 3, 13.5f, "rajabi", 14, 0);
            courses[2] = new Course("riazi", 2, 20, "hossaini", 8, 10);
            terms[0] = new Term(courses, 907);

            courses[0] = new Course("standard", 2, 16, "khaleghi", 12, 0);
            courses[1] = new Course("kar rah", 2, 19.25f, "ashrafi", 10, 0);
            courses[2] = new Course("tarbiat badani", 1, 15, "momen", 12, 30);
            terms[1] = new Term(courses, 805);

            students[2] = new Student(terms, "parsa 3", "ataei 3", 957, "computer engineering");
            Console.WriteLine($"student 3: {students[2].fullDegree()}");


        }
    }
}
