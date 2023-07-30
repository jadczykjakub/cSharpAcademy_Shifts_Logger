using cSharpAcademy_Shifts_Logger.Models;

namespace cSharpAcademy_Shifts_Logger
{
    public static class Helpers
    {
        public static Shift GetValidShiftObject(Shift shift)
        {
            TimeSpan duration = CalculateDuration(shift.DateFrom, shift.DateTo);

            shift.Duration = duration;

            return shift;
        }

        public static TimeSpan CalculateDuration(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException("Start date cannot be later than end date.");
            }

            return endDate - startDate;
        }
    }
}
