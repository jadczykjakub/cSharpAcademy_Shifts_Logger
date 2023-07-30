using cSharpAcademy_Shifts_Logger.Data;
using cSharpAcademy_Shifts_Logger.Interfaces;
using cSharpAcademy_Shifts_Logger.Models;

namespace cSharpAcademy_Shifts_Logger.Repository
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly DataContext _context;

        public ShiftRepository(DataContext context)
        {
            _context = context;
        }

        bool IShiftRepository.AddShift(Shift shift)
        {
            _context.Add(shift);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
