using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailControls
{
    public class NepDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        private string _weekDayName;
        public string WeekDayName
        {
            get { return _weekDayName; }
            set { _weekDayName = value; }
        }
        public int TIMESTAMP()
        {
            int t = 0;
            t = (Year * 10000) + (Month * 100) + (Day);
            return t;
        }

        public NepDate()
        {

        }

        public NepDate(int year,int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
        public string MonthName { get; set; }
        public int WeekDay { get; set; }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Year, Month, Day);
        }
        public string ToLongDateString()
        {
            return string.Format("{0}, {1} {2}, {3}", WeekDayName, MonthName, Day, Year);
        }

  
    }
}
