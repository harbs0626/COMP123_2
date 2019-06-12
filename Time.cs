using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_Theatre
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat }
    class Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Time(int hours, int minutes, int seconds = 0)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }

        public static bool operator !=(Time lhs, Time rhs)
        {
            return !lhs.Equals(rhs);
        }

        public static bool operator ==(Time lhs, Time rhs)
        {
            return lhs.Equals(rhs);
        }

    }
}
