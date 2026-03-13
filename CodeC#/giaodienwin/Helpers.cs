using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace giaodienwin
{
    public enum SpecialStatus
    {
        None,
        NearPoor,
        Poor
    }

    public class Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Date(int d = 1, int m = 1, int y = 1900)
        {
            Day = d;
            Month = m;
            Year = y;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year:D4}";
        }

        public static Date FromString(string str, out string errorMsg)
        {
            errorMsg = "";
            if (!Regex.IsMatch(str, @"^\d{2}/\d{2}/\d{4}$"))
            {
                errorMsg = "Dinh dang ngay phai la dd/mm/yyyy.";
                return new Date();
            }

            try
            {
                var parts = str.Split('/');
                int d = int.Parse(parts[0]);
                int m = int.Parse(parts[1]);
                int y = int.Parse(parts[2]);

                var date = new Date(d, m, y);
                if (!date.IsValid())
                {
                    errorMsg = "Ngay khong hop le.";
                    return new Date();
                }

                return date;
            }
            catch
            {
                errorMsg = "Loi khi phan tich ngay.";
                return new Date();
            }
        }

        public static Date CurrentDate()
        {
            var now = DateTime.Now;
            return new Date(now.Day, now.Month, now.Year);
        }

        public bool IsValid()
        {
            if (Month < 1 || Month > 12 || Day < 1 || Year <= 1900)
                return false;

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (DateTime.IsLeapYear(Year))
                daysInMonth[1] = 29;

            return Day <= daysInMonth[Month - 1];
        }

        public bool IsFuture()
        {
            DateTime current = DateTime.Now;
            DateTime thisDate = new DateTime(Year, Month, Day);
            return thisDate > current;
        }

        public bool IsExpired()
        {
            return !IsFuture();
        }
    }

    public static class Helpers
    {
        public static List<string> Split(string str, char delimiter)
        {
            return new List<string>(str.Split(delimiter));
        }

        public static bool IsValidIdNumber(string id, HashSet<string> usedIds, out string errorMsg)
        {
            errorMsg = "";
            if (string.IsNullOrEmpty(id))
                return true;

            if (id.Length != 9 && id.Length != 12)
            {
                errorMsg = "ID phai co 9 hoac 12 chu so.";
                return false;
            }

            if (!Regex.IsMatch(id, @"^\d+$"))
            {
                errorMsg = "ID chi duoc chua chu so.";
                return false;
            }

            if (usedIds.Contains(id))
            {
                errorMsg = "ID da duoc su dung.";
                return false;
            }

            usedIds.Add(id);
            return true;
        }

        public static string GetValidStringInput(string prompt, int maxLength, bool allowEmpty)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(input) && allowEmpty)
                    return "";

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Loi: Khong duoc de trong!");
                    continue;
                }

                if (input.Length > maxLength)
                {
                    Console.WriteLine($"Loi: Do dai toi da la {maxLength} ky tu!");
                    continue;
                }

                return input;
            }
        }

        public static int? GetValidIntegerInput(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out int value))
                {
                    if (value >= min && value <= max)
                        return value;
                    else
                        Console.WriteLine($"Loi: Gia tri phai tu {min} den {max}!");
                }
                else
                {
                    Console.WriteLine("Loi: Vui long nhap so nguyen hop le!");
                }
            }
        }
    }
}