
using System;

namespace BikeStore
{
    public static class ErrorLogValidation
    {
        public static bool IsValidDateRange(
            DateTime startDate,
            DateTime endDate)
        {
            return startDate.Date <= endDate.Date;
        }

        public static bool IsValidDateTimeRange(
            DateTime startDate,
            DateTime startTime,
            DateTime endDate,
            DateTime endTime)
        {
            DateTime start = startDate.Date + startTime.TimeOfDay;
            DateTime end = endDate.Date + endTime.TimeOfDay;

            return start <= end;
        }
    }
}
