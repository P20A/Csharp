using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_2
{
    internal class term
    {
        private course[] courses;
        private int termID;
        private int courseAmount;
        public course[] Courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public int TermID
        {
            get { return termID;}
            set { termID = value; }
        }
        public int CourseAmount
        {
            get { return courseAmount; }
            set { courseAmount = value; }
        }
        public term(course[] courses, int termID)
        {
            this.Courses = courses;
            this.TermID = termID;
        }
        public string toString()
        {
            return $"term id: {this.TermID},\ntotal degree: {totalDegree()}";
        }
        private float totalDegree()
        {
            float sum = 0f;
            course[] courses = this.Courses;
            for (int i = 0; i < courses.Length; i++)
            {
                sum += courses[i].CourseDegree * courses[i].CourseAmount;
            }
            return sum / calcCourseAmount();
        }
        private int calcCourseAmount()
        {
            int sum = 0;
            course[] courses = this.Courses;
            for (int i = 0; i < courses.Length; i++)
            {
                sum += courses[i].CourseAmount;
            }
            return sum;
        }
    }
}
