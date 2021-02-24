using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegistration
{
    class Time
    {
        public int ID { get; set; }
        public static int Time_ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Time()
        {
            ID = ++Time_ID;
        }
        public override string ToString()
        {
            return $"{ID}. {StartTime.ToShortTimeString()} - {EndTime.ToShortTimeString()}";
        }
    }
}
