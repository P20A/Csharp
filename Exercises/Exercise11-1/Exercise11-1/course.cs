using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_1
{
    internal class course
    {
        private string courseName;
        private int courseAmount;
        private float courseDegree;
        private string courseTeacher;
        private int courseTimeHour;
        private int courseTimeMinute;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public int CourseAmount
        {
            get { return courseAmount; } 
            set 
            { 
                if(value > 0)
                    courseAmount = value;
                else 
                    courseAmount = 0;
            }
        }
        public float CourseDegree
        {
            get { return courseDegree; }
            set
            {
                if(value > 0)
                    courseDegree = value;
                else
                    courseDegree = 0;
            }
        }
        public string CourseTeacher
        {
            get { return courseTeacher; }
            set { courseTeacher = value; }
        }
        public int CourseTimeHour
        {
            get { return courseTimeHour; }
            set
            {
                if( value > 0 && value < 24)
                    courseTimeHour = value;
                else if(value <= 0)
                    courseTimeHour = 0;
                else 
                    courseTimeHour = 23;
            }
        }
        public int CourseTimeMinute
        {
            get { return courseTimeMinute; }
            set
            {
                if (value > 0 && value < 60)
                    courseTimeMinute = value;
                else if (value <= 0)
                    courseTimeMinute = 0;
                else
                    courseTimeMinute = 59;
            }
        }
        public course(string courseName, int courseAmount, float courseDegree, string courseTeacher, int courseTimeHour, int courseTimeMinute)
        {
            this.CourseName = courseName;
            this.CourseAmount = courseAmount;
            this.CourseDegree = courseDegree;
            this.CourseTeacher = courseTeacher;
            this.CourseTimeHour = courseTimeHour;
            this.CourseTimeMinute = courseTimeMinute;
        }
        public string toString()
        {
            return $"Course Name: {this.CourseName},\nCourse Amount: {this.CourseAmount},\nCourse Degree: {this.CourseDegree},\nCourse Teacher: {this.CourseTeacher},\nCourse Time: {this.CourseTimeHour}:{this.CourseTimeMinute}";
        }
    }
}
