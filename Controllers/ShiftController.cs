using cSharpAcademy_Shifts_Logger.Data;
using cSharpAcademy_Shifts_Logger.Models;
using cSharpAcademy_Shifts_Logger.Services;
using Microsoft.AspNetCore.Mvc;

namespace cSharpAcademy_Shifts_Logger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        private readonly DataContext _context;

        public ShiftController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Shift> AddShift(Shift shift)
        {
            if (shift == null)
            {
                return BadRequest("Invalid data provided");
            }

            if (!_context.Workers.Any(w => w.WorkerId == shift.WorkerId))
            {
                return NotFound();
            }

            _context.Shifts.Add(ShiftService.GetValidShiftObject(shift));
            _context.SaveChanges();

            return Ok(shift);
        }
    }
}
