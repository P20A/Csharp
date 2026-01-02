using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_3
{
    internal class Term
    {
        private Course[] courses;
        private int termID;
        private int courseAmount;
        public Course[] Courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public int TermID
        {
            get { return termID; }
            set { termID = value; }
        }
        public int CourseAmount
        {
            get { return courseAmount; }
            set { courseAmount = value; }
        }
        public Term(Course[] courses, int termID)
        {
            this.Courses = courses;
            this.TermID = termID;
        }
        public string toString()
        {
            return $"term id: {this.TermID},\ntotal degree: {totalDegree()}";
        }
        public float totalDegree()
        {
            float sum = 0f;
            Course[] courses = this.Courses;
            for (int i = 0; i < courses.Length; i++)
            {
                sum += courses[i].CourseDegree * courses[i].CourseAmount;
            }
            return sum / calcCourseAmount();
        }
        private int calcCourseAmount()
        {
            int sum = 0;
            Course[] courses = this.Courses;
            for (int i = 0; i < courses.Length; i++)
            {
                sum += courses[i].CourseAmount;
            }
            return sum;
        }
    }
}
