using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Time
    {
        private int hours, minutes, seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = 0;
        }

        public Time(int hours)
        {
            this.hours = hours;
            this.minutes = 0;
            this.seconds = 0;
        }

        public Time()
        {
            this.hours = 0;
            this.minutes = 0;
            this.seconds = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Time theTime = new Time(7, 15, 0);

            Console.ReadKey();
        }
    }
}
