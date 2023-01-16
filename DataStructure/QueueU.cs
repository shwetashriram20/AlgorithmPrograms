using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16__17
{
    public class QueueU
    {
        public static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {                                                           // A leap year is exactly divisible by 4 except for century years (years ending with 00).
                if (year % 100 == 0)
                {                                                   // The century year is a leap year only if it is perfectly divisible by 400.
                    if (year % 400 == 0)
                    {                                                // only if it is perfectly divisible by 400.
                        return true;                                  // by using modulous(%) it checks if it is divisible or not.
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public int GetLast_Date(int month, int year)
        {
            int[] lastDates = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month == 2)
            {
                if (LeapYear(year))
                {
                    return 29;
                }
                else
                {
                    return lastDates[month - 1];
                }
            }
            else
            {
                return lastDates[month - 1];
            }
        }

        public int GetFirst_Date(int m, int d, int y)
        {
            int y1 = y - ((14 - m) / 12);
            int x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            int m1 = m + (12 * ((14 - m) / 12)) - 2;
            int d1 = (d + x + ((31 * m1) / 12)) % 7;
            return d1;
        }

        public string[,] GetCalenderArray(int firstDay, int lastDay)
        {
            string[,] calenderArray = new string[6, 7];
            int date = 1;
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    for (int j = 7 - firstDay; j < 7; j++)
                    {
                        calenderArray[i, j] += date;
                        date++;
                    }
                }
                else
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (date <= lastDay)
                        {
                            calenderArray[i, j] += date;
                            date++;
                        }
                    }

                }
            }
            return calenderArray;
        }
    }
}

