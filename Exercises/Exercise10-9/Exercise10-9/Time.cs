using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_9
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        private int Hour
        {
            get { return hour; }
            set
            {
                if (value < 24)
                    hour = value;
                else
                    hour = 23;
            }
        }
        private int Minute
        {
            get { return minute; }
            set
            {
                if (value < 60)
                    minute = value;
                else
                    minute = 59;
            }
        }
        private int Second
        {
            get { return second; }
            set
            {
                if (value < 60)
                    second = value;
                else
                    second = 59;
            }
        }
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public void setTime(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public string toString()
        {
            return $"{Hour}:{Minute}:{Second}";
        }
        public void nextSecond()
        {
            if (Second < 59)
                Second++;
            else
            {
                Second = 0;
                if (Minute < 59)
                    Minute++;
                else
                {
                    Minute = 0;
                    if (Hour < 23)
                        Hour++;
                    else
                        Hour = 0;
                }
            }
        }
        public void previousSecond()
        {
            if (Second > 1)
                Second--;
            else
            {
                Second = 59;
                if (Minute > 1)
                    Minute--;
                else
                {
                    Minute = 59;
                    if (Hour > 1)
                        Hour--;
                    else
                        Hour = 23;
                }
            }
        }
    }
}
