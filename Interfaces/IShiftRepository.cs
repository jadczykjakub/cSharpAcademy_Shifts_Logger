using cSharpAcademy_Shifts_Logger.Models;

namespace cSharpAcademy_Shifts_Logger.Interfaces
{
    public interface IShiftRepository
    {
        bool AddShift(Shift shift);
    }
}
