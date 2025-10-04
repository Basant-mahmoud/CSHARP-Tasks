using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedC__lab1
{
    struct HiringDate : IComparable<HiringDate>
    {
        private int day;
        private int month;
        private int year;

        public HiringDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
                throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31.");
            if (month < 1 || month > 12)
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
            if (year < 1900 || year > DateTime.Now.Year)
                throw new ArgumentOutOfRangeException(nameof(year), "Invalid year.");

            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int CompareTo(HiringDate other)
        {
            if (year != other.year)
                return year.CompareTo(other.year);
            if (month != other.month)
                return month.CompareTo(other.month);
            return day.CompareTo(other.day);
        }

        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
        public override bool Equals(object obj)
        {
            if (obj is HiringDate hd)
                return day == hd.day && month == hd.month && year == hd.year;
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(day, month, year);
    }

}
