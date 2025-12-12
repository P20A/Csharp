using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_8
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;
        public int Day
        {
            get { return day; }
            set 
            { 
                if(value <= 31 && value >= 1)
                    day = value; 
            }
        }
        public int Month
        {
            get { return month; }
            set 
            {
                if(value <= 12 && value >= 1)
                    month = value; 
            }
        }
        public int Year
        {
            get { return year; }
            set 
            { 
                if(value <= 9999 && value >= 1900)
                year = value; 
            }
        }
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
        public void setDate(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
        public string toString()
        {
            return $"{this.Day}/{this.Month}/{this.Year}";
        }
    }
}
