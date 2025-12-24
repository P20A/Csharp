using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            course course = new course("C#",3,19.67f,"mr sotodeh",19,0);
            Console.WriteLine(course.toString());
        }
    }
}
