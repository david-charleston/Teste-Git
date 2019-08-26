using System;

namespace ExtensionMetods.Extensions
{
    static class DateTimeExtensions
    {
        // Esse é um extension method
        public static string ElapsedTime(this DateTime dateTime)
        {
            string elapsedTime = "";
            TimeSpan duration = DateTime.Now.Subtract(dateTime);

            if (duration.TotalHours < 24)
            {
                elapsedTime = duration.TotalHours.ToString("F1") + " hours";
            }
            else
            {
                elapsedTime = duration.TotalDays.ToString("F1") + " days";
            }

            return elapsedTime;
        }
    }
}
