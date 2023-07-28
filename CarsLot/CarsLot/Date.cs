using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLot
{
    internal class Date
    {
        //declare variables
        int day;
        int month;
        int year;
        //class parameterized  constructor
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        //default constructor
        public Date()
        {
          
        }
        //set /getmethods
        public int Day {
            get {return day; }
            set {day=value; } 
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //function that returned the deffrence between tow dates
        public int Difference(Date pickDate,Date returnDate)
        {
            int totalDaysPick = pickDate.Year * 365 + pickDate.Month * 30 + pickDate.Day;
            int totalDaysReturn = returnDate.Year * 365 + returnDate.Month * 30 + returnDate.Day;
            return totalDaysReturn - totalDaysPick;
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }

}
