using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            course[] courses = new course[3];
            string courseName;
            int courseAmount;
            float courseDegree;
            string courseTeacher;
            int courseTimeHour;
            int courseTimeMinute;
            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write($"enter the #{i+1} course name: ");
                courseName = Console.ReadLine();
                Console.Write($"enter the #{i + 1} course amount: ");
                courseAmount = int.Parse(Console.ReadLine());
                Console.Write($"enter the #{i + 1} course degree: ");
                courseDegree = float.Parse(Console.ReadLine());
                Console.Write($"enter the #{i + 1} course teacher: ");
                courseTeacher = Console.ReadLine();
                Console.Write($"enter the #{i + 1} course time hour: ");
                courseTimeHour = int.Parse(Console.ReadLine());
                Console.Write($"enter the #{i + 1} course time minute: ");
                courseTimeMinute = int.Parse(Console.ReadLine());
                courses[i] = new course(courseName, courseAmount, courseDegree, courseTeacher, courseTimeHour, courseTimeMinute);
            }

            term term = new term(courses, 907);
            Console.WriteLine(term.toString());
        }
    }
}
