using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time1
{
    public class Time2
    {
        private int hour;
        private int minute;
        private int second;

        public Time2(int h = 0, int m = 0, int s = 0)
        {
            SetTime(h, m, s);
        }

        public Time2(Time2 time)
        : this(time.hour, time.minute, time.second) { }

        public void SetTime(int h, int m, int s)
        {
            if ((h <= 24 && h >= 0) && (m <= 60 && m >= 0) && (s <= 60 && s >= 0))
            {
                hour = h;
                minute = m;
                second = s;
            }
            else
                throw new ArgumentOutOfRangeException();
        }

        public string ToUniversalString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:D2}:{2:D2} {3}",
                ((hour == 0 || hour == 12) ? 12 : hour % 12),
                minute, second, hour < 12 ? "AM" : "PM");
        }
    }
}
