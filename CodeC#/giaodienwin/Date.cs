using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienwin
{
    
        public class Date
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public Date(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public static Date CurrentDate()
            {
                var now = DateTime.Now;
                return new Date(now.Day, now.Month, now.Year);
            }

            public static Date FromString(string dateStr, out string errorMsg)
            {
                errorMsg = "";
                var parts = dateStr.Split('/');
                if (parts.Length != 3 || !int.TryParse(parts[0], out int day) || !int.TryParse(parts[1], out int month) || !int.TryParse(parts[2], out int year))
                {
                    errorMsg = "Định dạng ngày không hợp lệ (dd/mm/yyyy)";
                    return new Date(1, 1, 2000);
                }

                if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900 || year > 2100)
                {
                    errorMsg = "Ngày, tháng hoặc năm không hợp lệ";
                    return new Date(1, 1, 2000);
                }

                return new Date(day, month, year);
            }

            public bool IsValid()
            {
                try
                {
                    new DateTime(Year, Month, Day);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public bool IsFuture()
            {
                var current = CurrentDate();
                if (Year > current.Year) return true;
                if (Year == current.Year && Month > current.Month) return true;
                if (Year == current.Year && Month == current.Month && Day > current.Day) return true;
                return false;
            }

            public bool IsExpired()
            {
                var current = CurrentDate();
                if (Year < current.Year) return true;
                if (Year == current.Year && Month < current.Month) return true;
                if (Year == current.Year && Month == current.Month && Day < current.Day) return true;
                return false;
            }

            public override string ToString()
            {
                return $"{Day:D2}/{Month:D2}/{Year}";
            }
        }
    }

