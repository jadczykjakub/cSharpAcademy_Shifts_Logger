namespace cSharpAcademy_Shifts_Logger.Models
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public TimeSpan? Duration { get; set; }
        public int WorkerId { get; set; }
    }
}
