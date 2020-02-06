using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayingData_ToString
{
    class Time
    {
        private int hour, minute, second;

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = 0;
        }

        public Time(int hours)
        {
            this.hour = hours;
            this.minute = 0;
            this.second = 0;
        }

        public Time()
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
        }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public void setTime(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public override String ToString()
        {
            return hour + ":" + minute + ":" + second;
        }

        public String displayTime()
        {
            return this.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time aTime = new Time(18, 23, 0);
            Console.WriteLine(aTime.displayTime());


            Console.ReadKey();
        }
    }
}
