using System;

namespace Libraries.Extensions.FluentDateTime
{
    public static class DateTimeExtensions
    {
        public static DateTime AddTimeSpan(this DateTime dateTime, TimeSpan timeSpan) => dateTime.Add(timeSpan);

        public static DateTime SubtractTimeSpan(this DateTime dateTime, TimeSpan timeSpan) => dateTime.AddTimeSpan(-timeSpan);

        public static DateTime StartOfDay(this DateTime dateTime) => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0, dateTime.Kind);

        public static DateTime EndOfDay(this DateTime dateTime) => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59, dateTime.Kind);

        public static DateTime StartOfWeek(this DateTime dateTime, DayOfWeek startOfWeek = DayOfWeek.Monday)
        {
            var diff = (7 + (dateTime.DayOfWeek - startOfWeek)) % 7;
            return dateTime.AddDays(-1 * diff).Date;
        }

        public static DateTime EndOfWeek(this DateTime dateTime, DayOfWeek startOfWeek = DayOfWeek.Monday) => dateTime.StartOfWeek(startOfWeek).AddDays(6);
    }
}
