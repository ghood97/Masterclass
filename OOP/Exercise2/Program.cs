using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class Time
    {
        private int hour, minute, second;

        public Time(int hour, int minute, int second)
        {
            this.hour = validateHour(hour);
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
            return formatTime();
        }

        private String formatTime()
        {
            String hours, minutes, seconds;
            if (hour < 10)
                hours = "0" + hour.ToString();
            else
                hours = hour + "";
            if (minute < 10)
                minutes = "0" + minute.ToString();
            else
                minutes = minute + "";
            if (second < 10)
                seconds = "0" + second.ToString();
            else
                seconds = second + "";

            return hours + ":" + minutes + ":" + seconds;

        }

        private int validateHour(int hour)
        {
            if (hour <= 23 && hour >= 0)
            {
                return hour;
            }
            else
            {
                return 0;
            }
        }

        public Boolean Equals(Time obj)
        {
            if (this.hour == obj.hour &&
                this.minute == obj.minute &&
                this.second == obj.second)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Time a = new Time(12, 30, 1);
            Time b = new Time(12, 30, 0);
            Console.WriteLine(a.Equals(b));

            Console.ReadKey();
        }
    }
}
