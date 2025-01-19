using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_OOP05
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Seconds: {Seconds}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d1, int totalSeconds)
        {
            int newTotalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + totalSeconds;
            return new Duration(newTotalSeconds);
        }

        public static Duration operator +(int totalSeconds, Duration d1)
        {
            return d1 + totalSeconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) - (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
            return new Duration(totalSeconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) < (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <= (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >= (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        public static Duration operator ++(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) + 60;
            return new Duration(totalSeconds);
        }

        public static Duration operator --(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) - 60;
            return new Duration(totalSeconds);
        }
        public static implicit operator bool(Duration d)
        {
            return (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) > 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds);
            return new DateTime(1970, 1, 1).AddSeconds(totalSeconds);
        }
    }
}
